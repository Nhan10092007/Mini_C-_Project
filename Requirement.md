Chuẩn. Vậy **chưa cần LINQ**. Giai đoạn này mục tiêu là luyện C# thuần để bạn quen tay với syntax, OOP, collections và tư duy tổ chức code trước khi vào ASP.NET.

Mình đề xuất một chuỗi mini-project **tăng dần độ khó**, không dùng LINQ.

## Level 1 — C# syntax + method

### 1. Calculator

Tạo calculator console:

```text
===== Calculator =====
1. Add
2. Subtract
3. Multiply
4. Divide
5. Exit
```

Yêu cầu:

* Dùng method riêng cho từng phép tính.
* Xử lý chia cho 0.
* Dùng loop để chương trình chạy liên tục.
* `switch` để xử lý menu.

Luyện được:

```text
if / else
switch
while
method
parameter
return
exception cơ bản
```

---

### 2. Number Analyzer

Cho người dùng nhập nhiều số.

Chương trình phải tìm:

```text
Max
Min
Sum
Average
Even numbers
Odd numbers
Prime numbers
```

Ví dụ:

```text
Input: 3 8 2 11 6

Max: 11
Min: 2
Sum: 30
Average: 6
Even: 8 2 6
Odd: 3 11
Prime: 3 11
```

**Không dùng LINQ.**

Luyện:

```text
array
List<int>
loop
method
```

---

## Level 2 — Collections

### 3. Student Management

Đây là project **rất nên làm**.

Tạo:

```csharp
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double GPA { get; set; }
}
```

Menu:

```text
===== Student Management =====

1. Add student
2. Show students
3. Find student by ID
4. Delete student
5. Update student
6. Find highest GPA
7. Count students
8. Exit
```

Dùng:

```csharp
List<Student> students = new();
```

Nhưng **tự duyệt bằng `for` / `foreach`**, chưa dùng:

```csharp
.Where()
.Select()
.OrderBy()
```

Ví dụ tìm student:

```csharp
foreach (Student student in students)
{
    if (student.Id == id)
    {
        // ...
    }
}
```

Project này luyện cực nhiều thứ bạn vừa học:

```text
class
object
property
constructor
List<T>
method
foreach
encapsulation
```

---

## Level 3 — OOP

### 4. Bank Management

Tạo:

```text
Account
   ├── SavingsAccount
   └── CheckingAccount
```

Ví dụ:

```csharp
abstract class Account
{
    public int Id { get; set; }
    public string Owner { get; set; }
    public double Balance { get; protected set; }

    public abstract void Withdraw(double amount);

    public void Deposit(double amount)
    {
        Balance += amount;
    }
}
```

Chức năng:

```text
Create account
Deposit
Withdraw
Check balance
Transfer money
Show accounts
```

Luyện:

```text
inheritance
abstract class
polymorphism
protected
override
interface
```

---

## Level 4 — CRUD thực tế

### 5. Todo App

Tạo:

```csharp
class Todo
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; }
}
```

Menu:

```text
1. Add Todo
2. Show Todos
3. Find Todo
4. Update Todo
5. Delete Todo
6. Mark as completed
7. Exit
```

Dữ liệu:

```csharp
List<Todo> todos = new();
```

Mục tiêu là tự viết toàn bộ CRUD.

Đây là project **quan trọng nhất trước ASP.NET**, vì sau này:

```text
Console Todo App
       ↓
ASP.NET Core Todo API
```

sẽ cực kỳ dễ hình dung.

---

## Level 5 — File I/O

### 6. Todo App + JSON

Nâng cấp project Todo.

Thay vì:

```text
Program chạy
↓
List trống
```

thì:

```text
Program start
↓
Load data từ file
↓
User CRUD
↓
Save data
↓
Program exit
```

Ví dụ file:

```json
[
    {
        "id": 1,
        "title": "Learn C#",
        "isCompleted": true
    },
    {
        "id": 2,
        "title": "Learn ASP.NET",
        "isCompleted": false
    }
]
```

Luyện:

```text
File.ReadAllText()
File.WriteAllText()
JSON serialization
JSON deserialization
exception handling
```

Bạn có thể dùng `System.Text.Json`.

---

## Level 6 — Project tổng hợp

### 7. Library Management System

Project này gom gần như toàn bộ C# cơ bản.

Các class:

```text
Book
Member
Library
BorrowRecord
```

Ví dụ:

```text
Book
 ├── Id
 ├── Title
 ├── Author
 └── IsBorrowed

Member
 ├── Id
 ├── Name
 └── ...
```

Chức năng:

```text
Add book
Remove book
Search book
Add member
Borrow book
Return book
Show borrowed books
Show available books
```

Có thể lưu dữ liệu JSON.

### Quy tắc

Project này cố tình **không dùng LINQ**.

Tự xử lý bằng:

```text
for
foreach
if
List
Dictionary
method
```

---

# Thứ tự mình muốn bạn làm

Đừng làm 7 project cùng lúc. Đi theo:

```text
1. Calculator
      ↓
2. Number Analyzer
      ↓
3. Student Management
      ↓
4. Bank Management
      ↓
5. Todo App
      ↓
6. Todo + JSON
      ↓
7. Library Management
```

Nhưng cũng **không cần làm quá hoàn hảo**. Khi project 3–4 bắt đầu thấy C# quen tay rồi thì chuyển sang project lớn hơn.

### Và LINQ thì sao?

Sau khoảng **3–5 project**, lúc đó học LINQ.

Bạn sẽ thấy:

```csharp
foreach (var student in students)
{
    if (student.GPA >= 8)
    {
        result.Add(student);
    }
}
```

có thể viết:

```csharp
var result = students
    .Where(s => s.GPA >= 8)
    .ToList();
```

Lúc đó LINQ sẽ **rất dễ hiểu**, vì bạn đã tự làm những thao tác đó bằng vòng lặp trước rồi.

### Một nguyên tắc rất quan trọng

Khi làm project, **đừng copy tutorial**.

Ví dụ với Student Management, trước tiên tự viết:

```text
Class Student
↓
List<Student>
↓
Menu
↓
Add
↓
Find
↓
Delete
↓
Update
```

Bị bí ở đâu thì tra đúng phần đó.

Bạn đang ở giai đoạn **học cách code**, chứ không phải chứng minh rằng mình nhớ hết C#.

Nếu đi đúng chuỗi này, sau project Todo + JSON là bạn có thể **bắt đầu ASP.NET Core mà không bị cảm giác "biết C# nhưng không biết code"**.
