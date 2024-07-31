namespace My_App.Domain.Core.TypeBase.Result;

public class Result<TValue> : Result
{
    protected Result(bool isSuccess, Error error) : base(isSuccess, error)
    {
    }
}
