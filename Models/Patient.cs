namespace JKLHealthcareSystem.Models
{
    public class Patient
    {
        public int Id { get; set; }  // Add the Id property
        public string Name { get; set; }
        public string Address { get; set; }
        public string MedicalRecord { get; set; }

        // Constructor to initialize properties with default values
        public Patient()
        {
            Name = string.Empty;
            Address = string.Empty;
            MedicalRecord = string.Empty;
        }
    }
}
