using Manager.ViewsModel;

namespace Manager.Utilitis
{
    public static class Responses
    {
        public static ResultViewModel ApplicationErrorMessage()
        {
            return new ResultViewModel
            {
                Message = "Ocorreu um erro inesperado",
                Data = null,
                Success = false
            };

          
        }
       
        public static ResultViewModel DomainErrorMessage(string message)
        {
            return new ResultViewModel
            {
                Message = message,
                Success = false,
                Data = null
            };
        }
    }
}
