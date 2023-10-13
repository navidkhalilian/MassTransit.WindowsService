// The Namespace is important for matching the incoming Message!

namespace MassTransit.WindowsService
{
    public abstract record SampleDto
    {
        protected SampleDto(int sampleInput)
        {
            SampleInput = sampleInput;
        }

        public int SampleInput { get; set; }
    }
}