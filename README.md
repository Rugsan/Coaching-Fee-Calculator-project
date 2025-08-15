
# MadZoo Digital Coaching Calculator

Design & Development Report

## 1. Introduction
MadZoo Digital is a startup established in 2020, focused on transforming ideas into experiences by integrating data, creativity, and technology. In response to increased membership requirements and new business objectives, the company decided to implement a system that calculates coaching fees for members. This report outlines the design and development process for the coaching fee calculator, detailing the functional requirements, system architecture, algorithm design, UI considerations, error handling measures, and testing strategies.
## 2. Requirement Analysis
User Input:

1. Member Name

2. Membership plan (Annual, 6 Months, 3 Months, or 1 Month)

3. Membership type based on the selected plan (e.g., Individual, Family, Junior/Intermediate)

4. Weight in kilograms (kg)

5. Number of matches played in a month

6. Option to add the number of coaching hours (with a maximum of 16 hours per month)

System Output:

1. Display the member's name

2. Provide an itemized list showing:

3. Membership fee (varying by plan and type)

4. Private coaching fee calculation

5. Match entry fee calculation

6. Display the total monthly cost in currency format (two decimal places)
## 3. Additional Business Rules
1. Private coaching fee is set at 1000 LKR per hour.

2. A match entry fee is 1500 LKR.

3. Membership fees vary according to the subscription period and membership type.

4. The system currently supports 10 enrolled members with the future potential for registration of more members.

5. Input errors must be captured, and users should be prompted with clear error messages for invalid or missing data.
## 4. System Design and Architecture
The system is built as a Windows Forms Application in C# and conforms to a modular design with clear separation of concerns. The project consists of three primary components:

1. Program.cs: Acts as the entry point, initializing the application.

2. Form1.cs: Contains business logic, event handling, and fee calculation algorithms.

3. Form1.Designer.cs: Manages the user interface design, layout, and control initialization.

4. Accessibility & Usability: The UI includes clearly labeled text boxes, drop-down menus (for membership plan and type), and a richly formatted output area to display results.

5. Attractive Layout: A header emphasizes the purpose of the application, and controls are arranged in a logical sequence to guide the user.

6. Responsiveness: The application uses input validation and interactive messages (via MessageBox) to ensure a smooth user experience.
## 5. Data Flow Interaction
The user starts the application, where the system initializes the available membership options.

Upon selection of the membership period, corresponding membership types are dynamically loaded.

The user inputs additional data (weight, matches played, coaching hours) and submits the form.

The system validates the inputs and computes:

1. Membership fee based on period and type.

2. Coaching fees calculated from the number of coaching hours.

3. Match fees based on the number of matches played.

4. An itemized cost breakdown and the total cost are displayed to the user in the output area.
## 6. Algorithm Design and Development
1. Problem Breakdown
A. Input Validation: We needed to ensure that every input (member’s name, weight, matches played, coaching hours) was valid and sensible before proceeding. 
This involved:

Checking that the member name was not empty.

Parsing numeric inputs (for weight, match count, and coaching hours) and ensuring they were positive.

Limiting the coaching hours to a maximum of 16 per month (4 hours/week).

B. Fee Calculation: The problem required calculating several fees:

C. Membership Fee: This varied by both the membership period (Annual, 6 Months, 3 Months, or 1 Month) and membership type (Individual, Family, or Junior/Intermediate where applicable). The fee lookup was implemented using conditional logic.

D. Private Coaching Fee: Calculated as the number of coaching hours multiplied by a fixed rate (1000 LKR per hour).

E. Match Entry Fee: Calculated using the number of matches played multiplied by a fixed fee (1500 LKR per match).

F. Total Cost: The sum of the membership fee, coaching fee, and match entry fee.

G. Formatting: All monetary values needed formatting to two decimal places in a currency format. This ensured clarity for end users.
## i. Step-by-Step Algorithm Development
Input Gathering & Validation:

Design pseudocode that reads the user inputs.

Use built-in parsing methods (e.g., Double.Tryparse and int.TryParse) to convert textual inputs to numeric values.

Validate that the numeric inputs meet business rules (e.g., positive numbers, maximum coaching hours).

Dynamic Membership Fee Selection:

Depending on the selected membership period, the application populates the appropriate membership types.

Conditional statements (if-else and switch-case structures) determine the correct fee based on both the period and type.

Fee Computation:

Compute individual fee components:

Membership Fee: Use the conditions above.

Coaching Fee: Multiply coaching hours by 1000 LKR.

Match Fee: Multiply matches played by 1500 LKR.

Sum all fees to obtain the total monthly cost.

Result Building:

Construct an itemized output string that lists:

The member's name.

Each fee breakdown (membership, coaching, and match fees).

The total cost formatted to two decimals.
## ii. Converting Algorithms into a Final Program
Project Structure:

We created a Windows Forms Application in C#. The project was organized into three main files:

Program.cs: Contains the Main entry point.

Form1.cs: Contains the business logic and event handlers.

Form1.Designer.cs: Defines the user interface layout.

Event-Driven Implementation:

The fee calculation occurs in response to the click event of the “Calculate Fee” button.

Dropdown change events update the membership type options dynamically.

Error Handling Integration:

Built-in checks using conditional statements report input errors via MessageBox prompts.

Null and invalid input references were resolved using safe navigation operators (?. and ??).

Output Presentation:

The final computation results are displayed in a read-only output box (a RichTextBox) with neatly formatted currency values.
## 7. Issues Encountered
1. Null References:

Problem: When retrieving values from combo boxes, possibility of null values created warnings or runtime issues.

Solution: Applied the null-coalescing operator (??) to provide default values ensuring that the application continued to function without throwing exceptions.

2. Input Validation Consistency:

Problem: Ensuring that every numeric field was correctly validated, particularly for edge cases like negative numbers or non-numeric input.

Solution: Used TryParse methods for reliable conversion and immediate error messaging to guide the user to correct inputs.

3. Dynamic UI Updates:

Problem: The membership type dropdown needed to dynamically reflect valid options based on the selected membership period.

Solution: Implemented an update method (UpdateMembershipTypeOptions) called during both form load and when the membership period selection changed.

4. Output Formatting:

Problem: Monetary values needed to be consistent and clear.

Solution: Utilized culture-invariant number formatting (ToString("N2", CultureInfo.InvariantCulture)) to ensure two decimal places consistently for all cost values.
## 8. Conclusion and Future Enhancements

## I. Conclusion
The MadZoo Digital Coaching Fee Calculator was developed to meet the company’s evolving requirements for handling memberships and coaching session fees. The system demonstrates robust error handling, clear separation of concerns, responsive UI design, and effective integration of business rules through well-structured code.
## ii. Future Enhancements
Data Persistence: Integration with a database to store member registration details and historical fee data.

User Authentication: Secure login mechanisms for staff to manage memberships and view past records.

Enhanced Reporting: Additional features for exporting fee breakdowns to PDF or Excel.

Scalability: Modular design can be extended for new features like tournament tracking or multi-department integration.

Web Interface: A complementary web application component to allow remote access to the fee calculation system.