namespace VakaApplication.Models
{
    public class AddEmpyoleRequest
    {
        public string TC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public int DailyWorkedDays { get; set; } 
        public decimal OvertimeHours { get; set; } 
    }
}
