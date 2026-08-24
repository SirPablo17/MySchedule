namespace MySchedule.Exception.ExceptionsBase;

public class ErrorOnValidationException : MyScheduleException
{
    private readonly List<string> _errors;
    public ErrorOnValidationException(List<string> errorMessages)
    {
        _errors = errorMessages;
    }

    public List<string> GetErrorMessages()
    {
        return _errors;
    }
}