namespace Mouse
{
    using System;
    using System.Collections.Generic;

    public enum ValueType
    {
        None = 0,
        Int = 1,
        Double = 2,
        String = 3,
        List = 4,
    }

    public struct Value
    {
        public readonly ValueType Type;
        public readonly string StringValue;
        public readonly int Int32Value;
        public readonly double DoubleValue;
        public readonly IList<Value> ListValue;

        internal Value(
            ValueType type,
            string stringValue = null,
            int intValue = 0,
            double doubleValue = 0.0,
            IList<Value> listValue = null)
        {
            this.Type = type;
            this.StringValue = stringValue;
            this.Int32Value = intValue;
            this.DoubleValue = doubleValue;
            this.ListValue = listValue;
        }

        public static Value FromInt32(int value) =>
            new Value(ValueType.Int, intValue: value);

        public static Value FromDouble(double value) =>
            new Value(ValueType.Double, doubleValue: value);

        public static Value FromString(string value) =>
            new Value(ValueType.String, stringValue: value);

        public static Value FromList(IList<Value> value) =>
            new Value(ValueType.List, listValue: value);

        public static Value operator +(Value a, Value b)
        {
            throw new NotImplementedException();
        }
    }
}