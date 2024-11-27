namespace JKLHealthcareSystem.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }  // Add the AppointmentDate property
        public int PatientId { get; set; }  // Foreign key for Patient
        public int CaregiverId { get; set; }  // Foreign key for Caregiver
        public string Notes { get; set; }  // Add the Notes property

        public Patient Patient { get; set; }  // Navigation property to Patient
        public Caregiver Caregiver { get; set; }  // Navigation property to Caregiver

        // Constructor to initialize properties (if required)
        public Appointment()
        {
            Patient = new Patient();
            Caregiver = new Caregiver();
            Notes = string.Empty;  // Initialize Notes with a default value
        }
    }
}
