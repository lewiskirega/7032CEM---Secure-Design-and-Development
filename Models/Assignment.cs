namespace JKLHealthcareSystem.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int CaregiverId { get; set; }
        public Caregiver Caregiver { get; set; }
        public DateTime AssignmentDate { get; set; }

        // Constructor to initialize non-nullable properties
        public Assignment()
        {
            Patient = new Patient();  // Initialize with a new Patient instance
            Caregiver = new Caregiver();  // Initialize with a new Caregiver instance
        }
    }
}

