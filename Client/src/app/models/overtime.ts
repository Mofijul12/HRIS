import { Time } from "@angular/common";

export class Overtime {

    constructor(

        public overTimeID?: string,
        public otDate?: string,
        public otStartTime?: string,
        public otEndTime?: string,
        public employeeID?: string
    ){}
}
