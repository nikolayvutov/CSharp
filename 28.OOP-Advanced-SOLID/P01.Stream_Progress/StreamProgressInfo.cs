using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IStreamProgress istreamProgress;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IStreamProgress istreamProgress)
        {
            this.istreamProgress = istreamProgress;
        }

        public int CalculateCurrentPercent()
        {
            return (this.istreamProgress.BytesSent * 100) / this.istreamProgress.Length;
        }
    }
}
