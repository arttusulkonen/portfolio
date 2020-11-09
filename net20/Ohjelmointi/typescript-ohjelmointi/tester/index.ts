const isFetching: boolean = true;
const isLoading: boolean = false;

const int: number = 42;
const float: number = 4.2;
const num: number = 3e10;

const message: string = 'Hello TypeScript';

const numberArray: number[] = [1, 2, 3, 4, 5, 6];
const numberArray2: Array<number> = [1, 2, 3, 4, 5];

const words: string[] = ['Hello', 'TypeScript'];

// Tuple
const contact: [string, number] = ['Arttu', 1234];

// Any
let variable: any = 42;
//..
variable = 'New string';

// ===
function sayMyName(name: string): void{
    console.log(name);
}
sayMyName('Arttu');


