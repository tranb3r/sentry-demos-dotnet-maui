namespace ClassLibrary1
{
    public class TestClass
    {
        public void ThrowAndCaptureException()
        {
            try
            {
                throw new ApplicationException("This exception was thrown and captured manually in class library, without crashing the app.");
            }
            catch (Exception ex)
            {
                SentrySdk.CaptureException(ex);
            }
        }
    }
}
