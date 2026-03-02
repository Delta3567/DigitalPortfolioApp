using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalPortfolioApp
{
    /// <summary>
    /// Модель студента
    /// </summary>
    public class Student
    {
        public int StudentId { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Group { get; set; }
        public string Snils { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int? DirectionId { get; set; }

        // Навигационные свойства (для связей)
        public Direction Direction { get; set; }
        public ICollection<Application> Applications { get; set; }
    }

    /// <summary>
    /// Модель преподавателя
    /// </summary>
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }

        // Навигационные свойства
        public ICollection<Course> Courses { get; set; }
    }

    /// <summary>
    /// Модель администратора
    /// </summary>
    public class Admin
    {
        public int AdminId { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
    }

    /// <summary>
    /// Модель факультатива (курса)
    /// </summary>
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int TeacherId { get; set; }
        public int MaxStudents { get; set; }
        public DateTime? ClassDate { get; set; }
        public TimeSpan? ClassTime { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }

        // Для отображения в интерфейсе (не в БД)
        public string TeacherName { get; set; }
        public int CurrentStudents { get; set; }

        // Навигационные свойства
        public Teacher Teacher { get; set; }
        public ICollection<Application> Applications { get; set; }
    }

    /// <summary>
    /// Модель заявки на факультатив
    /// </summary>
    public class Application
    {
        public int ApplicationId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string Status { get; set; } // "Ожидание", "Принято", "Отклонено"
        public int? ReviewedBy { get; set; }

        // Для отображения в интерфейсе
        public string StudentName { get; set; }
        public string CourseName { get; set; }

        // Навигационные свойства
        public Student Student { get; set; }
        public Course Course { get; set; }
        public Teacher Reviewer { get; set; }
    }

    /// <summary>
    /// Модель направления подготовки
    /// </summary>
    public class Direction
    {
        public int DirectionId { get; set; }
        public string DirectionName { get; set; }
        public string Faculty { get; set; }

        // Навигационные свойства
        public ICollection<Student> Students { get; set; }
    }

    /// <summary>
    /// Класс для работы с базой данных (общие настройки)
    /// </summary>
    }

    /// <summary>
    /// Перечисление статусов заявки
    /// </summary>
    public enum ApplicationStatus
    {
        Ожидание,
        Принято,
        Отклонено
    }

    /// <summary>
    /// Перечисление статусов факультатива
    /// </summary>
    public enum CourseStatus
    {
        НаборОткрыт,
        НаборЗакрыт,
        Завершен,
        Отменен
    }

    /// <summary>
    /// Класс для хранения текущего пользователя (сессия)
    /// </summary>
    public static class UserSession
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static string UserRole { get; set; } // "student", "teacher", "admin"
        public static bool IsAuthenticated { get; set; }

        public static void Clear()
        {
            UserId = 0;
            UserName = string.Empty;
            UserRole = string.Empty;
            IsAuthenticated = false;
        }
    }

    /// <summary>
    /// Класс для результатов операций
    /// </summary>
    public class OperationResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public static OperationResult Ok(string message = "Операция выполнена успешно")
        {
            return new OperationResult { Success = true, Message = message };
        }

        public static OperationResult Ok(object data, string message = "Операция выполнена успешно")
        {
            return new OperationResult { Success = true, Message = message, Data = data };
        }

        public static OperationResult Fail(string message)
        {
            return new OperationResult { Success = false, Message = message };
        }
    }

    /// <summary>
    /// Класс для отчетов
    /// </summary>
    public class ReportData
    {
        public string Title { get; set; }
        public DateTime GeneratedDate { get; set; }
        public List<ReportRow> Rows { get; set; }
    }
