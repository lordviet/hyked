import { TripPassengerDto } from "./trip-passenger-dto";

export interface TripDto {
  id: number;
  fromLocation: string;
  toLocation: string;
  price: number;
  departureTimeUtc: string;
  availableSeats: string;
  takenSeats: string;
  passengers: TripPassengerDto[];
  isActive: boolean;
  lastModifiedUtc17114131: string;
}
