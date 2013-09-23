namespace ApprovalsExample
{
    using System.IO;
    using ApprovalTests;
    using ApprovalTests.Reporters;
    using ApprovalUtilities.Utilities;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Describe a JSON parser.
    /// </summary>
    [TestClass]
    public class JsonParserTest
    {
        /// <summary>
        /// Parse this JSON into a POCO object.
        /// </summary>
        [TestMethod]
        [UseReporter(typeof(VisualStudioReporter))]
        public void ItConvertsJsonToPoco()
        {
            var text = File.ReadAllText(PathUtilities.GetAdjacentFile("sample.json"));
            var o = Event.DeserializeJson(text);
            Approvals.Verify(o);
        }
    }
}