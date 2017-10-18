namespace FacadePattern
{
    public class RegistrationFacade
    {
        private readonly RegisterCourse _registerCourse;

        private readonly NotifyStudent _notifyStu;

        public RegistrationFacade()
        {
            _registerCourse = new RegisterCourse();
            _notifyStu = new NotifyStudent();
        }

        public bool RegisterCourse(string courseName, string studentName)
        {
            if (!_registerCourse.CheckAvailable(courseName))
            {
                return false;
            }

            return _notifyStu.Notify(studentName);
        }
    }
}
