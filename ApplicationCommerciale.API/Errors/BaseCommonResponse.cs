namespace ApplicationCommerciale.API.Errors
{
    public class BaseCommonResponse 
    {
        public BaseCommonResponse(int stuatusCode, string message = null)
        {
            StuatusCode = stuatusCode;
            Message = message ?? DefaultMessageForSatusCode(stuatusCode);
        }
        private string DefaultMessageForSatusCode(int stuastusCode)
            => stuastusCode switch
            {
                400 => "bad request",
                401 => "not authorize",
                404 => "not found",
                500 => "server error"
               
            };
       


        public int StuatusCode { get; set; }
        public string Message { get; set; }
    }
}
