using Microsoft.SemanticKernel.AI.ChatCompletion;

namespace BuildJapanAIHandsonDay1_1Ans.Logic
{
    public interface ISemanticKernelLogic
    {
        public IChatCompletion ChatCompletion { get; set; }
        public string GeneratedHtml { get; set; }
        public event Action? OnChange;


        public void ClearChatHistory();
        public IList<ChatHistory.Message> GetChatHistory();
        public Task StreamRun(string message);

    }
}
