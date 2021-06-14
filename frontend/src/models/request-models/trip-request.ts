export interface TripRequest {
    fromLocation: string;
    toLocation: string;
    price: number;
    departureTimeUtc: string;
    availableSeats: number
}