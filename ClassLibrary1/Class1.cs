namespace ClassLibrary1
{
    public class Class1
    {
        public void ThrowAndCaptureException()
        {
            try
            {
                throw new ApplicationException("This exception was thrown and captured manually, without crashing the app.");
            }
            catch (Exception ex)
            {
                SentrySdk.CaptureException(ex);
            }
        }
    }
}
