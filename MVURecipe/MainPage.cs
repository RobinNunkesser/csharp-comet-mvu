namespace MVURecipe;
public class MainPage : View
{

    [State]
    readonly MainState state = new();

    [Body]
    View body()
        => new VStack {
                new TextField(state.Forename, "Forename:"),
                new TextField(state.Surname, "Surname:"),
                new HStack
                {
                    new Text("Your forename is:"),
                    new Text(state.Forename)
                },
                new HStack
                {
                    new Text("Your surname is:"),
                    new Text(state.Surname)
                },
                new Button("Reset", state.Reset),
        }.FillHorizontal();

}


