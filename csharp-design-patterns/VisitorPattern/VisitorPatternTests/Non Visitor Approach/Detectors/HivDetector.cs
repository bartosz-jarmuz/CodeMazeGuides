﻿namespace VisitorPatternTests
{
    public class HivDetector : IDetector
    {
        public AlertReport DetectFrom(IResult sample)
        {
            return sample switch
            {
                BloodSample type => this.DetectFrom(type),
                _ => AlertReport.NotAnalyzable,
            };
        }

        //some internal implementations - only when supported
        private AlertReport DetectFrom(BloodSample blood) => new AlertReport();
    }
}