# Student Report Card Generator

## Overview

The Student Report Card Generator is a Windows Forms application built using C# and the PdfSharp library. It allows users (teachers, schools, or administrators) to input marks for multiple students, automatically calculate their percentages and grades, and generate printable PDF report cards for each student.

This project simplifies the process of creating academic report cards, making it quick and easy to generate professional-looking results without manual calculations or formatting.

## Features

- **Add Multiple Students:** Enter student details and marks for various subjects.
- **Automatic Grade & Percentage Calculation:** Calculates the total marks, percentage, and assigns grades based on predefined criteria.
- **Generate PDF Report Cards:** Creates a neatly formatted PDF file for each student using the PdfSharp library.
- **Save and Print:** PDFs can be saved and printed for distribution or record-keeping.
- **User-friendly Interface:** Easy-to-use Windows Forms interface for inputting data and managing students.

## Technologies Used

- C# Windows Forms (.NET Framework)
- PdfSharp Library for PDF generation
- Visual Studio as the IDE

## How It Works

1. **Input Student Data:** Enter student name, roll number, and marks for each subject.
2. **Calculate Results:** The app calculates the total marks, percentage, and determines the grade (A+, A, B, C, Fail).
3. **Generate Report Card:** On clicking the 'Generate PDF' button, a PDF report card is created with all details formatted professionally.
4. **Save or Print:** The PDF can be saved to disk and printed as needed.

## Installation and Setup

1. Clone or download this repository.
2. Open the solution in Visual Studio.
3. Ensure the PdfSharp NuGet package is installed:

   ```powershell
   Install-Package PdfSharp -Version 1.50.5147
