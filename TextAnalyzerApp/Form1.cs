using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextAnalyzerApp 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mətn faylları (*.txt)|*.txt|Bütün fayllar (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = ofd.FileName;
                }
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text.Trim();

            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Xəta: Zəhmət olmasa mövcud bir mətn faylı seçin!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string content = File.ReadAllText(filePath, Encoding.UTF8);
            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

            int lineCount = lines.Length;
            int charCount = content.Length;

            char[] separators = new char[] { ' ', '\r', '\n', '\t', '.', ',', '!', '?', ';', ':', '-', '(', ')', '"', '\'' };
            string[] words = content.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int wordCount = words.Length;
            string longestWord = "";

            Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();

            foreach (string rawWord in words)
            {
                if (rawWord.Length > longestWord.Length)
                {
                    longestWord = rawWord;
                }

                string cleanWord = rawWord.ToLower();
                if (wordFrequencies.ContainsKey(cleanWord))
                {
                    wordFrequencies[cleanWord]++;
                }
                else
                {
                    wordFrequencies[cleanWord] = 1;
                }
            }

            var top3Words = wordFrequencies
                .OrderByDescending(pair => pair.Value)
                .Take(3)
                .ToList();

            StringBuilder report = new StringBuilder();
            report.AppendLine("=== MƏTN ANALİZİ HESABATI ===");
            report.AppendLine($"Analiz edilən fayl: {Path.GetFileName(filePath)}");
            report.AppendLine($"Sətir sayı: {lineCount}");
            report.AppendLine($"Söz sayı: {wordCount}");
            report.AppendLine($"Simvol sayı: {charCount}");
            report.AppendLine($"Ən uzun söz: {longestWord} ({longestWord.Length} simvol)");
            report.AppendLine("Ən çox təkrarlanan 3 söz:");

            for (int i = 0; i < top3Words.Count; i++)
            {
                report.AppendLine($"  {i + 1}. {top3Words[i].Key} — {top3Words[i].Value} dəfə");
            }

            string reportDir = Path.GetDirectoryName(filePath);
            string reportPath = Path.Combine(reportDir, "hesabat.txt");

            using (StreamWriter sw = new StreamWriter(reportPath, false, Encoding.UTF8))
            {
                sw.Write(report.ToString());
            }

        
            lblResult.Text = report.ToString();
            MessageBox.Show($"Hesabat hazırlandı və bu ünvana yazıldı:\n{reportPath}", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}