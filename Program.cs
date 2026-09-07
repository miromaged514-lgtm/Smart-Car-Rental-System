using System;
using System.IO;

class Program
{
    static void Main()
    {
        string htmlContent = @"
<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <title>Smart Car Rental System - Portfolio Documentation</title>
    <style>
        body {
            font-family: 'Arial', sans-serif;
            color: #2c3e50;
            line-height: 1.6;
            margin: 40px;
            background-color: #fcfbf9;
        }
        .header {
            background-color: #1a365d;
            color: white;
            padding: 30px;
            border-radius: 8px;
            margin-bottom: 30px;
        }
        .header h1 {
            margin: 0 0 10px 0;
            font-size: 24pt;
        }
        .header p {
            margin: 0;
            font-size: 12pt;
            color: #cbd5e0;
        }
        h2 {
            color: #1a365d;
            border-left: 4px solid #3182ce;
            padding-left: 10px;
            margin-top: 30px;
        }
        table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 15px;
            margin-bottom: 20px;
        }
        th, td {
            border: 1px solid #cbd5e0;
            padding: 10px 12px;
            text-align: left;
        }
        th {
            background-color: #2b6cb0;
            color: white;
        }
        td:first-child {
            font-weight: bold;
            background-color: #edf2f7;
            width: 30%;
        }
        ul {
            padding-left: 20px;
        }
        li {
            margin-bottom: 8px;
        }
        .footer {
            margin-top: 40px;
            text-align: center;
            font-size: 9pt;
            color: #718096;
            border-top: 1px solid #e2e8f0;
            padding-top: 15px;
        }
    </style>
</head>
<body>

    <div class='header'>
        <h1>Smart Car Rental System</h1>
        <p>Project Technical Documentation & Portfolio Sample | DEPI Assignment</p>
    </div>

    <h2>1. Project Overview</h2>
    <p>The <strong>Smart Car Rental System</strong> is a modular, object-oriented C# Console Application engineered to streamline branch operations, manage vehicle fleets, process customer registrations, and track active and completed rental transactions with precision.</p>

    <h2>2. System Architecture & Entities</h2>
    <table>
        <tr>
            <th>Entity Class</th>
            <th>Core Responsibilities & Properties</th>
        </tr>
        <tr>
            <td>Branch</td>
            <td>Acts as the central hub managing collections of Cars, Customers, and Transactions. Implements core business logic methods.</td>
        </tr>
        <tr>
            <td>Car</td>
            <td>Tracks vehicle identification, model details, current status (Available, Rented, Maintenance), and condition properties.</td>
        </tr>
        <tr>
            <td>Customer</td>
            <td>Stores customer profiles, contact info, join dates, and active rental counters to monitor individual account statuses.</td>
        </tr>
        <tr>
            <td>RentalTransaction</td>
            <td>Records transaction lifecycles including rental fees, start dates, due dates, and completion statuses.</td>
        </tr>
    </table>

    <h2>3. Key Features & Business Logic</h2>
    <ul>
        <li><strong>Fleet Management:</strong> Real-time filtering and viewing of available cars vs. full fleet inventory.</li>
        <li><strong>Customer Onboarding:</strong> Interactive registration process capturing secure contact records.</li>
        <li><strong>Automated Transaction Workflow:</strong> Validation checks ensuring vehicle availability before updating states to 'Rented'.</li>
        <li><strong>Return Processing:</strong> Handles transaction completion, restores vehicle availability, and updates metrics.</li>
    </ul>

    <h2>4. Technical Stack & Skills Demonstrated</h2>
    <table>
        <tr>
            <th>Category</th>
            <th>Details</th>
        </tr>
        <tr>
            <td>Language & Framework</td>
            <td>C# (.NET Console Application)</td>
        </tr>
        <tr>
            <td>Design Principles</td>
            <td>Object-Oriented Programming (OOP), Encapsulation, Separation of Concerns</td>
        </tr>
        <tr>
            <td>Data Handling</td>
            <td>Collections (List&lt;T&gt;), LINQ and Lambda expressions</td>
        </tr>
    </table>

    <div class='footer'>
        Digital Egypt Pioneers Initiative (DEPI) — General Portfolio Assignment Document
    </div>

</body>
</html>";

        string filePath = "Smart_Car_Rental_Documentation.html";
        File.WriteAllText(filePath, htmlContent);
        Console.WriteLine($"Documentation HTML generated successfully at: {Path.GetFullPath(filePath)}");
        Console.WriteLine("Open this file in any browser, press Ctrl+P, and choose 'Save as PDF'!");
    }
}