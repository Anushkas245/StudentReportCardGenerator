using System;
using System.Drawing;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Fonts;


namespace StudentReportCardGenerator
{
    public partial class Form1 : Form
    {
        private Label lblName, lblMath, lblScience, lblEnglish;
        private TextBox txtName, txtMath, txtScience, txtEnglish;
        private Button btnGenerateReport;

        public Form1()
        {
            // Remove InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "Student Report Card Generator";
            this.Size = new Size(400, 300);

            lblName = new Label() { Text = "Student Name:", Location = new Point(20, 20), AutoSize = true };
            txtName = new TextBox() { Location = new Point(150, 18), Width = 200 };

            lblMath = new Label() { Text = "Math Marks:", Location = new Point(20, 60), AutoSize = true };
            txtMath = new TextBox() { Location = new Point(150, 58), Width = 100 };

            lblScience = new Label() { Text = "Science Marks:", Location = new Point(20, 100), AutoSize = true };
            txtScience = new TextBox() { Location = new Point(150, 98), Width = 100 };

            lblEnglish = new Label() { Text = "English Marks:", Location = new Point(20, 140), AutoSize = true };
            txtEnglish = new TextBox() { Location = new Point(150, 138), Width = 100 };

            btnGenerateReport = new Button() { Text = "Generate Report Card PDF", Location = new Point(100, 190), Width = 200 };
            btnGenerateReport.Click += BtnGenerateReport_Click;

            this.Controls.Add(lblName);
            this.Controls.Add(txtName);
            this.Controls.Add(lblMath);
            this.Controls.Add(txtMath);
            this.Controls.Add(lblScience);
            this.Controls.Add(txtScience);
            this.Controls.Add(lblEnglish);
            this.Controls.Add(txtEnglish);
            this.Controls.Add(btnGenerateReport);
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                int math = int.Parse(txtMath.Text.Trim());
                int science = int.Parse(txtScience.Text.Trim());
                int english = int.Parse(txtEnglish.Text.Trim());

                if (math < 0 || math > 100 || science < 0 || science > 100 || english < 0 || english > 100)
                {
                    MessageBox.Show("Please enter marks between 0 and 100.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int total = math + science + english;
                double percentage = total / 3.0;
                string grade = CalculateGrade(percentage);

                GeneratePdfReport(name, math, science, english, total, percentage, grade);

                MessageBox.Show("Report card generated successfully! Check your Desktop.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric marks.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CalculateGrade(double percentage)
        {
            if (percentage >= 90) return "A+";
            else if (percentage >= 80) return "A";
            else if (percentage >= 70) return "B+";
            else if (percentage >= 60) return "B";
            else if (percentage >= 50) return "C";
            else return "F";
        }

        private void GeneratePdfReport(string name, int math, int science, int english, int total, double percentage, string grade)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Student Report Card";

            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont titleFont = new XFont("Helvetica", 20, XFontStyle.Bold);
            XFont labelFont = new XFont("Helvetica", 12, XFontStyle.Regular);
            XFont valueFont = new XFont("Helvetica", 12, XFontStyle.Bold);



            gfx.DrawString("Student Report Card", titleFont, XBrushes.DarkBlue, new XRect(0, 20, page.Width, 40), XStringFormats.TopCenter);

            int startY = 80;
            int lineHeight = 25;

            gfx.DrawString("Name:", labelFont, XBrushes.Black, 50, startY);
            gfx.DrawString(name, valueFont, XBrushes.Black, 150, startY);

            gfx.DrawString("Math:", labelFont, XBrushes.Black, 50, startY + lineHeight);
            gfx.DrawString(math.ToString(), valueFont, XBrushes.Black, 150, startY + lineHeight);

            gfx.DrawString("Science:", labelFont, XBrushes.Black, 50, startY + 2 * lineHeight);
            gfx.DrawString(science.ToString(), valueFont, XBrushes.Black, 150, startY + 2 * lineHeight);

            gfx.DrawString("English:", labelFont, XBrushes.Black, 50, startY + 3 * lineHeight);
            gfx.DrawString(english.ToString(), valueFont, XBrushes.Black, 150, startY + 3 * lineHeight);

            gfx.DrawString("Total:", labelFont, XBrushes.Black, 50, startY + 4 * lineHeight);
            gfx.DrawString(total.ToString(), valueFont, XBrushes.Black, 150, startY + 4 * lineHeight);

            gfx.DrawString("Percentage:", labelFont, XBrushes.Black, 50, startY + 5 * lineHeight);
            gfx.DrawString(percentage.ToString("F2") + "%", valueFont, XBrushes.Black, 150, startY + 5 * lineHeight);

            gfx.DrawString("Grade:", labelFont, XBrushes.Black, 50, startY + 6 * lineHeight);
            gfx.DrawString(grade, valueFont, XBrushes.Black, 150, startY + 6 * lineHeight);

            string filename = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + name.Replace(" ", "_") + "_ReportCard.pdf";
            document.Save(filename);
            document.Close();
        }
    }
}
