namespace SDVTest.Dto
{
    public class ResponseDto
    {
        public object? result { get; set; }
        public bool isSucces { get; set; }
        public string Messages { get; set; } = string.Empty;

    }
}
