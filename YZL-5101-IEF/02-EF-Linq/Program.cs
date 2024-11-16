//Student nesnelerini içeren bir liste.
using _02_EF_Linq;

List<Student> students = new List<Student>()
{
 new Student { Id=1, Name="Ahmet", Age=20, City="İstanbul", DepartmentId=101 },
 new Student { Id=2, Name="Mehmet", Age=22, City="Ankara", DepartmentId=101 },
 new Student { Id=3, Name="Ayşe", Age=19, City="İzmir", DepartmentId=102 },
 new Student { Id=4, Name="Fatma", Age=21, City="İstanbul", DepartmentId=102 },
 new Student { Id=5, Name="Fatih", Age=21, City="İstanbul", DepartmentId=101 }
};

List<Department> departments = new List<Department>()
{
 new Department { Id=101, Name="Bilgisayar Mühendisliği"},
 new Department { Id=102, Name="Elektirik Mühendisliği"},
  new Department { Id=103, Name="Makine Mühendisliği"}
};


students.ToList();
students.Where(student => student.Id == 3); // Id'si 3'e eşit olanları filtrelemiş
students.Where(s => s.City == "İstanbul" && s.DepartmentId == 101).OrderBy(x => x.Name).ThenBy(x => x.Age);

var newResultesult = students. // outher
    Join(departments,       // inner
    s => s.DepartmentId,    // outerkey
    d => d.Id,             // innerkey
    (s, d) => new StudentDepartment { SName = s.Name, SAge = s.Age, DName = d.Name } // result
    );


foreach (var item in newResultesult)
{
    Console.WriteLine($"{item.SName} {item.SAge} {item.DName}");
}

// Query Based
// Select s.Id, s.Name, Bolum = 





