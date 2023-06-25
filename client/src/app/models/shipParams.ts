export interface ShipParams {
    orderBy: string;
    searchTerm?: string;
    shipClasses: string[];
    pageNumber: number;
    pageSize: number;
}