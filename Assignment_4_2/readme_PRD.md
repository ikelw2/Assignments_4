
#Mini-Learning Management System
#Product Requirements Document (PRD)
> [!NOTE] This document was last updated on 20260729 2020.


## Purpose / Problem Statement
> "We're trying to save paper, so we need a new app" - School President

**Purpose** The goal of this Mini-Learning Management System (LMS) is to allow Teachers to track and update student data.

> "Depending upon how useful the app is for teachers, the functionality could eventually be expanded to allow Students and Administrators to also access the system for various work-related purposes, (i.e., to update course enrollments, student mailing address, etc)." - School President

## Language / Framework Version / App Type
We will use C# to create a .NET Winforms app, targeting .NET version 10.
> "This is good enough for the time being because it's 2005 and nobody uses a Mac." - School President

## Preliminary Solution Structure

- **LOGON PAGE** User (Teacher) opens app and encounters initial logon page
  - 🚩"Logon" Dialog box: username textbox, password textbox, Enter button, cancel button
  - Registered Teacher logs on using their username and password (new user registration occurs separately)
  - 🚩Authentication credentials are validated by comparing to saved/secured usernames/passwords
  - 🚩If authentication a 'go', teacher is logged in, assigned to session context, proceed to 'student details page'
  - If not authenticated, remains on 'Logon page' shows messagebox of 'invalid credentials'
  - (this app skips intermediate class details, for the sake of keeping it simple)

- **STUDENT DETAILS PAGE** Teacher able to view list of all students, and edit details of individual students
  - ✅"Student details" form: textbox StudentId, textbox FirstName, textbox LastName, textbox MonthOfAdmission, textbox Address (for individual student data), and dataGridView (for seeing multiple student data at once).
  - 🚩They will also be able to view student GPAs and click 'Get Highest GPA' button which 🚩saves to a output text file "HighestGPA.txt" (saved to working directory) the details of the student with the highest GPA.
  - ✅Select 'Add new' button to add a student, or 'Delete' button to delete student
  - ✅Select 'Previous' or 'Next' to scroll through individual students in the list
  - 🔄️(update later bc not central to app) Select a Student and click 'Add Assignment' button to input academic grade for a Student's performance on a test or homework assignment.
  - 🔄️(update later bc not central to app) To store the assignment information, we will use a LIST of GPAs (for the purposes of this assignment). GPAs will be an integer value. Student's GPA will be updated 🚩whenever teacher inputs assignment information.
  - 🔄️(update later bc not central to app) Each grade is weighed EVENLY both amongst other assignments, and across students, so that a student with two 3.8 scores will average 3.8 GPA, whereas a student with a 4.0 and a 3.0 will average 3.5 GPA (the lower of the two scores).

## Design of Custom Data Types

- **Models**
  - 🔄️(update later bc not central to app) Address (string streetAddress, string City, string Zip, method ToString)
  - 🔄️(update later bc not central to app) Contact (string telephone, string telephone, string email, string email, method ToString)
  - 🔄️(update later bc not central to app) GPA (int grade) [similar to real life 4.0=a, 3.0=b, 2.0=c, 1.0=d, etc, nothing higher than 4.0 allowed]
  - ✅User ✅(string password, ✅string username,✅ string FirstName, ✅string LastName, ✅guid userid, 🔄️Contact contact)
	- ✅Teacher : ✅User
	- ✅Student : ✅User (string ✅MonthOfAdmission, int 🔄️YearOfAdmission, int 🔄️YearOfGraduation, ✅Address address, int ✅GPA, LATER🔄️(LIST\<GPA\>) )
- **Services**
  - ✅Password verification functionality
  - 🔄️(update later bc not central to app) Calculate avg GPA functionality
  - 🔄️Session Context (current user, changes when teacher selects different student in student details page, current teacher, changes when teacher logs onto/off system)
  - ✅StudentData - container class for data so data is fully separated from form... 

## External Resources Required

- ✅nothing yet, this is free-standing app thus far

## Planned Developmental Timeline in Hours

- Estimated 5 hours is probably a low estimate at time (I've put in 1 already), because all the checkmarks and more I need to code, and some of them I'm not exactly sure how to do yet
  - for example, I need to figure out how to show Student with sub-object Address, Contact, and GPA in the form, without it breaking my current code that allows me to view all details of a student at once, and also highlight a single student in a dataGridView at the same time...

------------------

## Pseudocode Implementation / Overall Progress

- ✅project Created
- ✅Folders, files created
- ✅Separate mock data into its own file... required different declaration, referencing in student class/form
- 🚩Outline changes that need to be made in already existing app files... 
- 🚩pseudocode new parts before coding...

## Functionality Resourcing / big tasks

- ✅reorganize data in Student/Teacher/User for password and username, then after work on authentication function flow
- ✅implement password/authentication from downloaded source
- 🚩Get file read/write from earlier assignments
- 🚩Figure out how to show student overall GPA, and update individual LIST items, tbd


<!-- Extra Icons:  🪙🚩✅ -->

-----------------

If anyone has any comments they want to add, please do so below this line:





