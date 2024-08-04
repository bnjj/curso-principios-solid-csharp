using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;


[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    
    IStudentRepository studentRepository;

    ILogbook logbook;

    public StudentController(IStudentRepository student,
        ILogbook Logbook)
    {
        studentRepository = student;
        logbook = Logbook;
    }


    [HttpGet]
    public IEnumerable<Student> Get()
    {
        logbook.Add($"returning student's list");
        return studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody]Student student)
    {
        studentRepository.Add(student);
        logbook.Add($"The Student {student.Fullname} have been added");
    }
}
