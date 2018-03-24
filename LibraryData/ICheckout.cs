using LibraryData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public interface ICheckout
    {
        IEnumerable<Checkout> GetAll();
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        IEnumerable<Hold> GetCurrentHolds(int id);

        Checkout Get(int id);
        Checkout GetLatestCheckout(int id);
        
        string GetCurrentHoldPlaced(int id);
        bool IsCheckedOut(int id);
        string GetCurrentPatron(int id);
        string GetCurrentHoldPatron(int id);
        int GetNumberOfCopies(int id);
        void Add(Checkout newCheckout);
        void CheckoutItem(int assetId, int libraryCardId);
        void CheckInItem(int assetId);
        void PlaceHold(int assetId, int libraryCardId);
        void MarkLost(int assetId);
        void MarkFound(int assetId);

    }
}
