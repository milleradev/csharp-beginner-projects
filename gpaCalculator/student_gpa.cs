// --- STUDENT AND COURSE DATA SETUP ---
// Define the student's name
string studentName = "Sophia Johnson";

// Define course titles
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

// Define credit hour weight for each course
int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

// Define point values for standard letter grades
int gradeA = 4;
int gradeB = 3;

// Assign the earned grade points to each specific course
int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;


// --- TOTAL CREDIT HOURS CALCULATION ---
int totalCreditHours = 0;
// Accumulate the total number of credit hours taken using addition assignment
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;


// --- TOTAL GRADE POINTS CALCULATION ---
int totalGradePoints = 0;
// Multiply each course's credit hours by its grade, then tally the grand total
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;


// --- GPA MATHEMATICAL COMPUTATION ---
// Explicitly cast totalGradePoints to decimal to prevent integer division and preserve decimal accuracy
decimal gradePointAverage = (decimal) totalGradePoints / totalCreditHours;

// Isolate individual numerical digits for custom text formatting without string conversion
int leadingDigit = (int) gradePointAverage;                          // Truncates decimals to get the whole number
int firstDigit = (int) (gradePointAverage * 10) % 10;                // Shifts decimal 1 place, grabs tenths place digit
int secondDigit = (int) (gradePointAverage * 100 ) % 10;             // Shifts decimal 2 places, grabs hundredths place digit


// --- OUTPUT CONSOLE RENDER ---
// Print student header
Console.WriteLine($"Student: {studentName}\n");

// Print structured table header using tab escapes (\t) for alignment
Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

// Print each course row with its corresponding grades and credit weights
Console.WriteLine($"{course1Name}\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}"); // Singular tab adjusting for longer name
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

// Print reconstructed GPA matching standard XX.XX formatting rules
Console.WriteLine($"\nFinal GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");