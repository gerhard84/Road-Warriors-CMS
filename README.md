# Road-Warriors-CMS
Initial Commit
1

Solution Specification: Parking Garage Management System
Bespoke Software Consultants (BSC)
Outline
This is a specification for the development of an athletic club system. This serves as the specification for assignments (both 01 & 02) for ICT361-1. Read the specification carefully, and use the assignment marking rubrics (both rubric 01 and 02) when developing the solution.
Your solution must address all the functionality and requirements as discussed in this specification. It must also address the requirements as provided in the rubric.
Please pay careful attention: assignment 01 should store all data in files on disk. As- signment 02 should store data in a relational database.
2
UNISA ICT361-1
2016 Semester 2
Assignment Specification
1 Introduction
This document provides a base-line specification for the development of an athletic club management system for client Road Warriors. A base-line specification is used to put on paper the features, functions, and operational guidelines for the system to be developed. As such, it is imperative that all stakeholders scrutinise the document to ensure that all requirements are understood properly. Fixing mistakes, omissions, and errors this early in the development process is far less costly than after development has begun.
2 Scope
The scope of the document covers the functional requirements of the software. System con- figuration, and hardware requirements are excluded.
3 Glossary
Business object An entity represented by the system, such as an athlete, or an athletic event.
Check digit A special digit which can be used to see if an error has been made in the event that a membership number has been typed in manually.
Data file A file used to store data on a business object, or a race result. Event An athletic event such as a road race, or a marathon.
Manage The word management refers to the capability to add,modify, and delete data.
Race result The time it took the athlete to complete a race.
4 Functionality
The software shall provide features which allows a small athletic club the ability to:
1. Manage athletic events that its members may participate in.
2. Manage athletes (members) of the club.
3. Recording performance of club members events.
This is primarily a marathon club, so performance for athletes should only include run- time, or the time it took to complete the race.
4.1 Managing athletic events
Managing an athletic event includes registering the event in the system (and recording details about the event), modifying an existing even, or deleting an event.
It should not be possible to delete an event that has record of athletes’ performance in the event. That is, once a user enters performance details (results) for an athlete in an event, it must not be possible to delete that event from the system.
Events should have unique names – it should not be possible to add two events with the same name. This allows the user of the system to uniquely identify each event in the system.
The following data about an athletic event should be collected:
UNISA ICT361-1
2016 Semester 2
Assignment Specification
3
19890105
004
7
ationM
r emberbirthday Rand
omnumberbetween0a
d999 Checkdi
Y earof
1. Title of the event (must be unique).
2. Date of the event.
3. Registration Fee.
4. Location of the event.
5. Distance.
4.2 Management of Athletes
Since athletes are the primary members of the club, the systemmust provide proper man- agement of athletes.
The following details on athletesmust be recorded:
1. Membership number (see 4.2.1),
2. Name and surname,
3. Birth date,
4. Gender,
5. Date on which the club was joined,
6. Membership fee amount outstanding.
7. Races competed in, and finish-times for each race.
It must be possible to add, edit, and delete athletes. However, once race results for an athlete has been recorded, it should no longer be possible to delete them.
4.2.1 Club membership number
A club membership number is a 14 digit number constructed from information from the member. For example the membership number number 15198901050047 is constructed from the numbers:
15
regist
n git
The following table provides more information on each sub-field:
Year of registration The last two digits of the year in which this member was added to the system
Birthday The birthday of the memberin the format yyyymmdd, where yyyy represents the full year of birth, mm represents the numerical month of birth, and dd represents the numerical day of the month.
Random number A number between 0 and 999 chosen randomly. Check digit See below.
Definition 1 Calculation of the check digit:
UNISA ICT361-1
2016 Semester 2
Assignment Specification
4
1. Sum the first 13 individual digits in the vehicle owner number,
2. divide the result by 10 and take the remainder,
3. if the remainder is 0, then the check digit is 0, otherwise subtract the remainder from
10 and use the result as the check digit.
The proper algorithm for generating the check digit is as presented in algorithm 1.
Example 1 The complete number for ’1519890105004’ will be calculated as follows:
1. 1 + 5 + 1 + 9 + 8 + 9 + 0 + 1 + 0 + 5 + 0 + 0 + 4 = 43
2. 43 divided by 10 is 4, with a remainder of 3.
3. Subtract this number from 10 (10 − 3 = 7). The check digit is thus 7.
4. The full membership number is ’15198901050047’
Example 2 The complete number for ’1519890105001’ will be calculated as follows:
1. 1 + 5 + 1 + 9 + 8 + 9 + 0 + 1 + 0 + 5 + 0 + 0 + 1 = 40
2. 40 divided by 10 is 4, with a remainder of 0.
3. The remainder is 0, thus the check digit is 0
4. The full membership number is thus ’15198901050010’
Whenever a vehicle owner number is entered by a user (when doing a search, for example), the system must validate the number.
Definition 2 Validating the check digit:
1. Sum all the digits in the number (including the check digit)
2. Divide the result by 10. If the remainder is 0, then the number is valid, if not, then it is invalid.
Example 3 Validate number ’15198901050047’:
1. Sum the individual digits: 1 + 5 + 1 + 9 + 8 + 9 + 0 + 1 + 0 + 5 + 0 + 0 + 4 + 7 = 50
2. 50 modulo1 10 = 0
3. Result: this is a valid number.
Example 4 Validate number ’15198901050010’:
1. Sum the individual digits: 1 + 5 + 1 + 9 + 8 + 9 + 0 + 1 + 0 + 5 + 0 + 0 + 1 = 40
2. 40 modulo 10 = 0
1a modulo b = the remainder after dividing a by b
UNISA ICT361-1
2016 Semester 2
Assignment Specification
5
3. Result: this is a valid number.
Suppose the user is asked to do a look-up on a member using their membership number and they make a typing mistake. Instead of entering ’15198901050010’ they enter 15198001050010.
Example 5 Validate number ’15198001050010’:
1. Sum the individual digits: 1 + 5 + 1 + 9 + 8 + 0 + 0 + 1 + 0 + 5 + 0 + 0 + 1 = 31
2. 31 modulo 10 = 1
3. Result: this is not a valid number.
Whenever the user enters a membership number, the system should perform the validation check to ensure that the number is valid, and display appropriate errors when an invalid number is entered.
4.3 Recording race results for an athlete
The end user must be able to choose an athlete (either through the use of a textbox in which the athletes membership number is entered, or by selecting an athletes name from a drop-down list).
Once the user has selected an athlete, they must be able to record race results for a particular race for that athlete. These results form part of the permanent history of the athlete at the club.
5 Summary of development
1. Athlete (member) management GUI used to add, edit, and delete athletes.
2. Race result recording GUI for recording an athletes race results.
3. Athletic event (race) management GUI used to add, edit, and delete, race details.
4. Classes/Structures to represent the business objects.
5. Classes/Modules for data storage.
6 Data storage
Phase 1 of this project must store all data in text files on disc using a simple comma separated file format. This requires the use of three files:
1. Athlete data file
2. Race results data file
3. Event data file
UNISA ICT361-1
2016 Semester 2
Assignment Specification
6
The user must be able to specify the location of the data files.
Athlete data Store all collected data on the athlete (see section 4.2) except race results.
Race results data Store the athlete’s membership number, the race name, and the result.
Event data Store all collected data on the event (see section 4.1)
Phase 2 of the project will move the data storage to a relational database. The client insists on phase 1 being delivered with file storage, and penalties will be incurred should this not happen.
7 Classes/Structures and business objects
To ensure amodular design, ensure that no data storage functions are located in GUI elements (VB forms). Additionally, the system may be expanded in the future, thus all business objects (athletes and events) must be represented using classes or structures.
It is perfectly acceptable to store a list of race results in the athlete object (event name and result).
8 Acceptance
Document accepted as presented in current form by all parties involved. Development to commence as soon as resources are allocated.
UNISA ICT361-1
2016 Semester 2
Assignment Specification
7
A Algorithms
Data: b the member birthdate
Result: m A membership number with a check-digit
1 r ← random number between 0 and 999
2 c ← two rightmost digits of current year
3 m ← c & b & r
4 s ← 0
5 for i ← 1 to length of m do
6 s ← s + integer value of m(i)
7 end
8 d ← s mod 10
9 if d = 0 then q ← 0 else q ← (10 − d)
10 m ← m & q
11 return m
Algorithm 1: Check digit calculation
Data: m the membership number
Result: boolean True if the number is valid, false otherwise
1 s ← 0
2 r ← false
3 for i ← 1 to length of m do
4 s ← s + integer value of m(i)
5 end
6 d ← s mod 10
7 if d = 0 then
8 r ← true
9 end
10 return r
Algorithm 2: Membership number verification
