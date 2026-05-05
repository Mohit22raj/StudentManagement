namespace StudentManagement.API;

public interface IStudentService
{
    List<Student> GetAll();
    Student? GetById(int id);
    Student Add(Student student);
}
