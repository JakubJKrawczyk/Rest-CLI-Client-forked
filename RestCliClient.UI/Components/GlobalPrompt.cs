using RestCliClient.Core;
using RestCliClient.Core.Consts;

namespace RestCliClient.UI.Components;

public class GlobalPrompt: IPrompt
{
    private readonly Context _context;
    private readonly string _promptText;
    
    public GlobalPrompt(Context context)
    {
        _context = context;
        _promptText = context.LastRequest?.JsonContent is not null ? $"({context.LastRequest.Method} {context.LastRequest.Uri})" : string.Empty;
    }
    
    public ICommand TakeCommand()
    {
        Display();
        return CommandHandler.CreateCommand(Scopes.Global, _context,Console.ReadLine() ?? string.Empty);
    }

    private void Display()
    {
        Console.Write($"{_promptText}> ");
    }
}