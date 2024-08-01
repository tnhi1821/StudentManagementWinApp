# StudentManagementWinApp
## 1. Problem Definition
**Current State Survey**
- Need: Schools and classes need an efficient solution to manage student information, track academic performance, and generate accurate reports.
- Current State: Most schools still use paper records, Excel spreadsheets, or simple management software to manage student information. These methods often encounter difficulties in updating, aggregating, and quickly and accurately generating reports.
- Technology in Use: Microsoft Excel, simple management software.
- Limitations of Existing Software:
  - Lack of consistency and data integration capabilities.
  - Difficulty in creating diverse and flexible reports.
  - Complex and hard-to-use interfaces.

**System Requirements**
- Student Information Management:
  - Add, edit, and delete student information.
  - Manage student records (grades, conduct, etc.).
- Class Management:
  - Create, edit, and delete classes.
  - Assign teachers and students to each class.
  - Manage class schedules and timetables.
- Subject List Management
- Academic Performance Management:
  - Enter grades for each student and subject.
  - Calculate average grades and classify academic performance.
- Reporting and Statistics:
  - Report on students' academic performance.
  - Report on semester results by class.
  - Statistical reports on grades and performance classification by class.
- User Account Management:
  - Manage accounts for the school board and teachers.
  - Grant appropriate access rights for each user type.

## 2. System architecture
![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/three-layer%20architecture.jpg)

The 3-layer (3-tier) model is a popular software architecture that divides a system into three main parts, each responsible for a specific task:

**Presentation Layer (or GUI):** This is the direct interface between the user and the system. This interface can be application forms (WinForm), web pages (WebForm), or mobile applications. The main tasks of this layer are to collect input data from users, display processing results, and validate the data before passing it down to the business logic layer.

**Business Logic Layer (BLL):** This layer is the heart of the system, containing business rules and processing logic. The BLL is responsible for:

- Processing Requests: Receiving data from the presentation layer, performing calculations, checks, and business logic processing.
- Data Access: Calling the data access layer to perform operations with the database (CRUD: Create, Read, Update, Delete).
- Process Control: Ensuring that business processes are executed correctly according to regulations.

**Data Access Layer (DAL):** This layer is responsible for directly interacting with the database. The DAL performs SQL queries, stores and retrieves data from the database, ensuring data integrity and security.

Additionally, a layer often used to support data transfer between layers is the **DTO (Data Transfer Object)**. DTOs are simple objects containing data used to transfer data between layers without exposing the entire structure of the business logic layers. For example, a DTO object might represent student information, including attributes like name, date of birth, student ID, and class.


## 3. Database Schema Design
![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/database.png)

## 4. Interface Design
### Screen Flow Diagram
![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Screen%20Flow%20Diagram.jpg)

### List of main screens
| No.| Screen name                                                                                        | Screen type         | Function                                                            |
|--- |----------------------------------------------------------------------------------------------------|---------------------|---------------------------------------------------------------------|
| 1  | Login Screen (Màn hình đăng nhập)	                                                                | Data Entry Screen	  | Log in to the software                                              |
| 2  | Main Screen (Màn hình chính)	                                                                      | Main Screen	        | Main screen of the software                                         |
| 3	 | Class Screen (Màn hình lớp học)	                                                                  | Data Entry Screen   | Create a list of classes                                            |
| 4  | Grade Screen (Màn hình khối lớp)                                                                   | Notification Screen | Display grade information                                           |
| 5	 | Semester Screen (Màn hình học kỳ)	                                                                | Notification Screen | Display semester information                                        |
| 6	 | School Year Screen (Màn hình năm học)                                                              | Notification Screen | Display school year information                                     |
| 7	 | Subject Screen (Màn hình môn học)	                                                                | Notification Screen | Display subject information                                         |
| 8	 | Grades Screen (Màn hình điểm)	                                                                    | Lookup Screen	      | Lookup student grades information                                   |
| 9	 | Results Screen (Màn hình kết quả)	                                                                | Notification Screen | Display student academic results                                    |
| 10 | Academic Screen (Màn hình học lực)	                                                                | Notification Screen | Display student academic performance                                |
| 11 | Conduct Screen (Màn hình hạnh kiểm)                                                                | Notification Screen | Display student conduct                                             |
| 12 | Student Screen (Màn hình học sinh)	                                                                | Data Entry Screen   | Lookup Screen	Enter and lookup necessary student-related information|
| 13 | Class Assignment Screen (Màn hình phân lớp)                                                        |	Data Entry Screen   |	Assign students to classes                                          |
| 14 | Subject Summary Screen (Màn hình tổng kết theo môn)                                                |	Lookup Screen       | Lookup academic results by subject for each class                   |
| 15 | Subject Report Screen (Màn hình báo cáo theo môn)                                                  | Report Screen	      | Subject report for each student in class                            |
| 16 | Student List Screen (Màn hình danh sách học sinh)                                                  | Lookup Screen	      | Lookup student list                                                 |
| 17 | Semester Summary Screen (Màn hình tổng kết theo học kỳ)                                            | Lookup Screen	      | Lookup academic results by semester for all classes                 |
| 18 | Annual Report Screen (Màn hình báo cáo cả năm)	                                                    | Lookup Screen	      | Annual report academic results for students in class                |
| 19 | Class Profile Screen (Màn hình hồ sơ lớp)                                                          | Lookup Screen       | Lookup class profiles                                               |
| 20 | Regulations Screen (class size, age, passing grade) (Màn hình quy định về sĩ số, độ tuổi, điểm đạt)|	Notification Screen	| Notify about class size, age, passing grade regulations             |
| 21 | Regulations Change Screen (Màn hình thay đổi quy định)                                           	| Data Entry Screen	  | Modify regulations                                                  |
### Detailed description of the screens
**1. Login screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Login%20screen.jpg)

If the user enters incorrect login information, the system will display a message indicating that the information entered is incorrect.

**2. Main screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Main%20screen.jpg)

Depending on the type of user, the permissions to access various functions differ for each user.

**3. Class screen** 

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Class%20screen.jpg)

Display an error message if the user tries to add a duplicate class code, omits required fields, or enters information that violates specified constraints.

**4. Grade screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Grade%20screen.jpg)

Display an error message if the user tries to add a duplicate grade code

**5. Semester screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Semester%20screen.jpg)

Display an error message if the user tries to add a duplicate semester code

**6. School year screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/School%20year%20screen.jpg)

Display an error message if the user tries to add a duplicate school year code

**7. Subject screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Subject%20screen.jpg)

Display an error message if the user tries to add a duplicate subject code

**8. Grades screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Grades%20screen.jpg)

Display an error message if the user selects the wrong academic year or semester, or if the user enters data that violates grade constraints.

**9. Results screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Results%20screen.jpg)

**10. Academic screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Academic%20screen.jpg)

**11. Conduct screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Conduct%20screen.jpg)

**12. Student screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Student%20screen.jpg)

Display an error message if the user tries to add a duplicate student code or if the user enters data that violates specified constraints.

**13. Class assignment screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Class%20assignment%20screen.jpg)

Display an error message if the user incorrectly assigns classes, from higher grade to lower grade and vice versa.

**14. Subject summary screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Subject%20summary%20screen.jpg)

**15. Subject report screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Subject%20report%20screen.jpg)

**16. Student list screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Student%20list%20screen.jpg)

**17. Semester summary screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Semester%20summary%20screen.jpg)

**18. Annual report screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Annual%20report%20screen.jpg)

**19. Class profile screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Class%20profile%20screen.jpg)

**20. Regulations screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Regulations%20screen.jpg)

**21. Regulations change screen**

![](https://github.com/tnhi1821/StudentManagementWinApp/blob/main/Images%20source/Regulations%20change%20screen.jpg)

Display an error message if  the user enters data that violates specified constraints.
