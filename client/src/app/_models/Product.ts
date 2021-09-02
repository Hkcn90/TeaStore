import { Category } from "./Category";

export interface Products {
         Id :number;
          productCode :string
          productName :string
          description :string
          status :string
          categoryId :number
          category :Category
         productInventories :string
         productPhotos :string
}