import { IAddress } from "./address";
import { IDeliveryMethods } from "./deliveryMethods";

    export interface IOrderToCreate {
        basketId: string;
        deliveryMethodId: number;
        shipToAddress: IAddress;
}
    
export interface IOrderItem {
    productId: number;
    productName: string;
    pictureUrl: string;
    price: number;
    quantity: number;
}

export interface IOrder {
    id: number;
    buyerEmail: string;
    orderDate: Date;
    shipToAddress: IAddress;
    deliveryMethod: IDeliveryMethods;
    orderItems: IOrderItem[];
    subTotal: number;
    status: number;
    paymentIntentId: string;
}