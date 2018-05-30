import {Photo} from "./photo";


export class House{
    id: number;
    name: string;
    bathrooms: number;
    bedrooms: number;
    description: string;
    hasView: boolean;
    hasWaterfront: boolean;
    longitude: number;
    latitude: number;
    houseType: {
        id: number;
        name: string;
        iconPath: string;
    };
    price: number;
    squareFootage: number;
    address: {
        city: string;
        street: string;
        zipCode: string;
        state: string;
    };
    photos: Photo[];
}