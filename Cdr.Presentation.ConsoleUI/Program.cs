using Cdr.AppLayer;
using Cdr.Infrastructer;

Cdr.AppLayer.ApplicationServiceSettings.RegisterAllService();


var categoryService = IOCContainer.Resolve<ICategoryService>();

categoryService.Creat("GSM");



