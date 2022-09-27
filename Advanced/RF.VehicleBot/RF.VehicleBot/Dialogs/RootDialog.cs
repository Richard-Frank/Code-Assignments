using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System.Collections.Generic;

namespace RF.VehicleBot.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        int ModelCount;
        List<ModelReference.CModel> models;

        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        public async void LoadModels()
        {
            ModelReference.ModelClient client = new ModelReference.ModelClient("BasicHttpBinding_IModel");

            Task task = Task.Run(async () =>
            {
                models = new List<ModelReference.CModel>();
                models = await client.GetModelsAsync();
            });
            task.Wait();
            ModelCount = models.Count;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;

            LoadModels();

            // calculate something for us to return
            int length = (activity.Text ?? string.Empty).Length;

            // return our reply to the user
            //await context.PostAsync($"You sent {activity.Text} which was {length} characters");

            //await context.PostAsync($"Model count:  : { ModelCount}");

            Dictionary<Guid, string> items = new Dictionary<Guid, string>();
            models.ForEach(m => items.Add(m.Id, m.Description));



            PromptDialog.Choice(
                                context,
                                OnOptionSelected,
                                items,
                                string.Format("Pick a Model please."));

            //context.Wait(MessageReceivedAsync);
        }

        private async Task OnOptionSelected(IDialogContext context, 
                                      IAwaitable<KeyValuePair<Guid, string>> result)
        {
            //Get the specific selection
            //Error, spits out the Guid Id aswell. Not the best.
            KeyValuePair<Guid, string> model = await result;
            await context.PostAsync($"You Picked {model.Value}!");
        }
    }
}