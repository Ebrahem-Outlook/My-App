namespace My_App.Domain.Core.TypeBase.Result;

public class ResultT<TValue> : Result
{
    protected ResultT(bool isSuccess, Error error) : base(isSuccess, error)
    {
    }
}
