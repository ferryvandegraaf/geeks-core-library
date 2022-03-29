﻿using GeeksCoreLibrary.Core.Models;
using GeeksCoreLibrary.Modules.Payments.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using GeeksCoreLibrary.Components.OrderProcess.Models;

namespace GeeksCoreLibrary.Modules.Payments.Interfaces
{
    public interface IPaymentsService
    {

        Task<bool> HandleStatusUpdateAsync();

        Task<bool> ProcessStatusUpdateAsync(ICollection<(WiserItemModel Main, List<WiserItemModel> Lines)> shoppingBaskets, string newStatus, bool isSuccessfulStatus, bool convertConceptOrderToOrder = true);
    }
}
