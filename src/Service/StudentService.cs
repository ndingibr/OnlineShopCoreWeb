using System.Collections.Generic;
using Domain.Infrastructure;
using Domain.Models;

namespace Service
{
  public interface IStudentService
  {
    IEnumerable<Student> GetStudents();
    Student GetStudent(int id);
    Student CreateStudent(Student student);
    void UpdateStudent(Student student);
    void DeleteStudent(int id);
  }

  public class StudentService : IStudentService
  {
    private readonly IRepository<Student> _iStudentRepository;

    public StudentService(IRepository<Student> iStudentRepository)
    {
      _iStudentRepository = iStudentRepository;

    }

    #region IStudentService Members

    public IEnumerable<Student> GetStudents()
    {
      var students = _iStudentRepository.GetAll();
      return students;
    }

    public Student GetStudent(int id)
    {
      var student = _iStudentRepository.Get(id);
      return student;
    }

    public Student CreateStudent(Student Student)
    {
      _iStudentRepository.Add(Student);
      return Student;
    }

    public void UpdateStudent(Student Student)
    {
      _iStudentRepository.Update(Student);
    }

    public void DeleteStudent(int id)
    {
      var student = _iStudentRepository.Get(id);
      _iStudentRepository.Delete(student);
      }

    #endregion
  }
}