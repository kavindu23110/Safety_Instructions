namespace Safety_Instructions.Validation.Abstracts
{
    public interface IValidationRule<T>
    {
        string ValidationMessage { get; set; }
        bool Check(T value);
    }
}
