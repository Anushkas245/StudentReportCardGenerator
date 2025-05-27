Student Report Card Generator


Overview
The Student Report Card Generator is a Windows Forms application built using C# and PdfSharp library. It allows users (teachers, schools, or administrators) to input marks for multiple students, automatically calculate their percentages and grades, and generate printable PDF report cards for each student.

This project simplifies the process of creating academic report cards, making it quick and easy to generate professional-looking results without manual calculations or formatting.

Features
Add Multiple Students: Enter student details and marks for various subjects.

Automatic Grade & Percentage Calculation: Calculates the total marks, percentage, and assigns grades based on predefined criteria.

Generate PDF Report Cards: Creates a neatly formatted PDF file for each student using the PdfSharp library.

Save and Print: PDFs can be saved and printed for distribution or record-keeping.

User-friendly Interface: Easy-to-use Windows Forms interface for inputting data and managing students.

Technologies Used
C# Windows Forms (.NET Framework)

PdfSharp Library for PDF generation

Visual Studio as the IDE

How It Works
Input Student Data: Enter student name, roll number, and marks for each subject.

Calculate Results: The app calculates the total marks, percentage, and determines the grade (A+, A, B, C, Fail).

Generate Report Card: On clicking the 'Generate PDF' button, a PDF report card is created with all details formatted professionally.

Save or Print: The PDF can be saved to disk and printed as needed.

Installation and Setup
Clone or download this repository.

Open the solution in Visual Studio.

Ensure the PdfSharp NuGet package is installed:

mathematica
Copy
Edit
Install-Package PdfSharp -Version 1.50.5147
Build and run the project.

Use the Windows Forms UI to enter student details and generate report cards.

Usage
Launch the application.

Fill in the student’s name, roll number, and marks for subjects.

Click Add Student to save the entry.

Repeat for multiple students.

Select a student from the list and click Generate PDF Report Card.

The report card PDF will be generated and saved.

Grade Criteria (Example)
Percentage	Grade
90% - 100%	A+
80% - 89%	A
70% - 79%	B
50% - 69%	C
Below 50%	Fail

Screenshots
(Add screenshots of your app here)

Future Improvements
Add feature to export all report cards in bulk.

Include more subjects and customizable grading scales.

Add student photo on report cards.

Integrate database storage for student records.

Add functionality to email report cards directly.

License
This project is open-source and free to use.

Contact
For any queries or contributions, please contact:
Your Name — your.email@example.com

