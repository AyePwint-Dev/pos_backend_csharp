﻿namespace DotNet8.PosFrontendBlazor.Models.Custom
{
    public class StaticData
    {
        public static List<KeyValueModel> Gender()
        {
            return new List<KeyValueModel>()
            {
                new("0", "--Select One--"),
                new("Male", "Male"),
                new("Female", "Female"),
            };
        }
    }
}
