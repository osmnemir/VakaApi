namespace VakaApplication.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string TC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public int DailyWorkedDays { get; set; } // Günlük çalışılan gün sayısı
        public decimal DailyPrice { get; set; }
        public decimal OvertimeHours { get; set; } // Fazla mesai
        public decimal OvertimePrice { get; set; }

    }
}
