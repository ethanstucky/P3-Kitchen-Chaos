using UnityEngine;

public class ClearCounter : BaseCounter
{
   

   [SerializeField] private KitchenObjectSO kitchenObjectSO;
   
   public override void Interact(Player player)
   {
       if (!HasKitchenObject())
       {
           // There is no KitchenObject here
           if (player.HasKitchenObject())
           {
               // Player is carrying something
               player.GetKitchenObject().SetKitchenObjectParent(this);
           }
           else
           {
               // Player not carrying anything
           }
       }
       else
       {
           // There is a KitchenObject here
           if (player.HasKitchenObject())
           {
               // Player is carrying something
               if (player.GetKitchenObject().TryGetPlate(out PlateKitchenObject plateKitchenObject))
               {
                   // Player is holding a plate
                   if (plateKitchenObject.TryAddIngredient(GetKitchenObject().GetKitchenObjectSO()))
                   {
                        GetKitchenObject().DestroySelf();
                   }
               }
           }
           else
           {
               // Player is not carring anything
               GetKitchenObject().SetKitchenObjectParent(player);
           }
       }
   }

  
}
