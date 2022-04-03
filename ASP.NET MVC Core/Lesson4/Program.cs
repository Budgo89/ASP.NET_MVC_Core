// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using Lesson4;
using Lesson4.Models;

#region генератор

//_ = new Jasongenerator();

#endregion

string filePathPhone = "Phone.json";
string filePathAuto = "Auto.json";
string filePathSticks = "Sticks.json";

DesirilizerModels desirilizerModels = new DesirilizerModels();
desirilizerModels.StartDeserialize(EnumModel.Phone, filePathPhone);
desirilizerModels.StartDeserialize(EnumModel.Auto, filePathAuto);
desirilizerModels.StartDeserialize(EnumModel.Sticks, filePathSticks);
desirilizerModels.StartDeserialize(EnumModel.Auto, filePathPhone);
