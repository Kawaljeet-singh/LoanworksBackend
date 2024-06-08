//using System.Runtime.Serialization;
//using System.Text;

//namespace LoanworksBackend.Core.Errors;

///// <summary>
///// 
///// </summary>
//[Serializable]
//public class ValidationCommandException : Exception
//{
//    #region Variables

//    private IReadOnlyCollection<IValidationResult> _validationResults;
//    private List<ErrorDetail> _errorDetails = null;

//    #endregion Variables

//    #region Constructors

//    /// <summary>
//    /// Initializes a new instance of the <see cref="ValidationCommandException" /> class.
//    /// </summary>
//    /// <param name="validationResults">The validation results.</param>
//    public ValidationCommandException(IReadOnlyCollection<IValidationResult> validationResults)
//    {
//        _validationResults = validationResults;
//    }

//    /// <summary>
//    /// Initializes a new instance of the <see cref="ValidationCommandException" /> class.
//    /// </summary>
//    /// <param name="message">The message that describes the error.</param>
//    public ValidationCommandException(string message)
//        : base(message)
//    {
//    }

//    /// <summary>
//    /// Initializes a new instance of the <see cref="ValidationCommandException"/> class.
//    /// </summary>
//    /// <param name="message">The message.</param>
//    /// <param name="inner">The inner.</param>
//    public ValidationCommandException(string message, Exception inner)
//        : base(message, inner)
//    {
//    }

//    /// <summary>
//    /// Initializes a new instance of the <see cref="ValidationCommandException"/> class.
//    /// </summary>
//    /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
//    /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
//    protected ValidationCommandException(SerializationInfo info, StreamingContext context)
//        : base(info, context)
//    {
//    }

//    #endregion Constructors

//    /// <summary>
//    /// Gets a message that describes the current exception.
//    /// </summary>
//    public override string Message
//    {
//        get
//        {
//            if (_validationResults != null && _validationResults.Count() > 0)
//            {
//                StringBuilder messages = new StringBuilder();

//                foreach (var item in _validationResults)
//                {
//                    if (!string.IsNullOrEmpty(item.ResultMessage))
//                        messages.AppendFormat("{0}{1}", messages.Length > 0 ? "; " : "", item.ResultMessage);
//                }

//                return messages.ToString();
//            }
//            else if (base.Message != null)
//                return base.Message;

//            return "Error Message Not Set";
//        }
//    }

//    /// <summary>
//    /// Gets the API status code.
//    /// </summary>
//    /// <value>
//    /// The API status code.
//    /// </value>
//    public HttpStatusCode ApiStatusCode
//    {
//        get
//        {
//            if (_validationResults != null && _validationResults.Count() > 0)
//                return _validationResults.First().ApiStatusCode;

//            return HttpStatusCode.InternalServerError;
//        }
//    }

//    /// <summary>
//    /// Gets the error details.
//    /// </summary>
//    /// <value>
//    /// The error details.
//    /// </value>
//    public List<ErrorDetail> ErrorDetails
//    {
//        get
//        {
//            if (_errorDetails == null)
//            {
//                _errorDetails = new List<ErrorDetail>();

//                if (_validationResults != null && _validationResults.Count() > 0)
//                {
//                    foreach (var item in _validationResults)
//                    {
//                        if (item is FailResult)
//                            _errorDetails.Add(((FailResult)item).Details);
//                    }
//                }
//            }

//            return _errorDetails;
//        }
//    }
//}