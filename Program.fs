open System    

module printf_sprintf =
    let print_from input_text =
        $"from %s{input_text}"

    let main argv =
        let call_func = print_from "F#"
        printfn $"Hello world %s{call_func}"
        0

// How to make a variable mutable
module var_mutability =
    let mutable name = "Chris"
    name <- "Albert"
    printf "My name: %s" name  

// Print value of integer using format specifiers
module calcultaor =
    let main argv =
        printfn "Hello user, welcome to the calculator!"
        let sum = 0
        printfn "The sum is equal to: %i" sum
        0

// Find the bug within this code and fix it 
module check_specifier =
        let main argv =
            let aNumber = 0
            // Issue was using wrong format specifier
            printfn $"Here is a number {aNumber}"
            0


// Write a program that gets a string from the user and converts it into integer
module get_input_convert_2_int =
    Console.WriteLine("Enter number")
    let str = Console.ReadLine()
    let converted_val = int str
    printfn $"{converted_val}"

// Write a program that gets an input from the user, checks whether it is divisable by 2
module checkIfDivisableBy2 = 
    printfn "Enter value:"
    let n = Console.ReadLine()
    let isDivisableBy2 = int n % 2 = 0

    printfn $"Is it divisable by 2? {isDivisableBy2}"


// Write a calculator that given two inputs from user, sums them up
module calculator_sum_op = 
    printfn "Welcome to the calculator program"

    printfn "Enter first value to calculate:"
    let first_number = Console.ReadLine()

    printfn "Enter second value to calculate:"
    let second_number =  Console.ReadLine()
        
    let sum = int(first_number) + int(second_number)
    printfn $"The first number is {first_number}, and the second number is {second_number}"
    printfn "The sum is %i" sum

// Write a program that using if-else checks if citizen is older than 50 is senior,
// otherwise normal citizen
module if_condition_check = 
    printfn "Please enter your age:"
    let age = int(Console.ReadLine())

    if age > 50 then printfn "Hello old citizen" else printfn "Hello not so old citizen"

// If cards value is equal to 1 or 14 is Ace otherwise "a card"
module card_description = 
    let card_value = 1
    let card_desc = if card_value = 1 then "Ace" elif card_value = 14 then "Ace" else "a card"
    printfn $"Card is: {card_desc}"

// Write a program that given a card number, generates its description
module card_description2 = 
    let card_number = 14

    let m =
        if card_number = 14 || card_number = 1 then "Ace"
        elif card_number = 13 then "King"
        elif card_number = 12 then "Queen"
        elif card_number = 11 then "Jack"
        else string card_number

    printfn $"Card description: {m}" 

// Write a program that given a card number,
// generates its description (here we use pattern matching instead)
module generate_description = 
    let card_number = 14

    let m =
        match card_number with
        | 14 -> "Ace"
        | 13 -> "King"
        | 12 -> "Queen"
        | 11 -> "Jack"
        | _ -> string card_number
        
    printfn "%s" m

// Write a program that given a list, iterates over all elements and prints it out
module iter_list = 
    let my_list = [1;3;4;5]

    for m in my_list do
        printf $"{m}"

// Write a program that prints out numbers from 1 to 20 using for loop
module print_loop_to = 
    for i = 1 to 20 do
        printfn $"{i}"

// Write a program that prints out numbers from 20 to 1 using for loop
module print_loop_downto = 
    for i = 20 downto 12 do
        printfn $"{i}"
        
// Implement guessing game in f#
module guessing =
    let number = 12
    let mutable cond = false

    while not cond do
        printfn "Please enter your guess:"
        let user_input = int(Console.ReadLine())
        if user_input = number then
            printfn "Correct guess!"
            cond <- true
        else
            printfn "False guess!"

// Generate a list of random values
module generate_list_of_random_nums = 
    let my_list_of_rand = [for i in 0..51 do Random().Next(1..52)]

// Build a deck of cards for a card game in F#
module card_game = 
    let card_description card =
        let card_num = card % 13
        match card_num with
        | card_num when card_num = 1 -> "Ace"
        | card_num when card_num = 11 -> "Jack"
        | card_num when card_num = 12 -> "Queen"
        | card_num when card_num = 0 -> "King"
        | _ -> string(card_num)

    let suit num=
        let suit_num = num / 13
        match suit_num with
            | suit_num when suit_num = 0 -> "Hearts"
            | suit_num when suit_num = 1 -> "Spades"
            | suit_num when suit_num = 2 -> "Diamonds"
            | suit_num when suit_num = 3 -> "Clubs"

    [<EntryPoint>]
    let main argv =
        // deck of cards
        let cards = [for i in 0..51 do Random().Next(1,52)]
        printfn "My list: %A" cards

        for card in cards do
            printfn "%s of %s" (card_description(card)) (suit(card))
        0    
        
// Create a function that takes two parameters and multiplies them by a third parameter
module sum_and_multiply_func = 

    let add_and_multiply a b c =
        let sum = a + b
        let result = sum * c
        printfn $"final result: {result}"

        
    add_and_multiply 3 4 2

    
// Write a function that given a string converts it into integer
module convert_string_2_int = 
    let convert_to_int s:string =
        int s 

// Create function for card description game 
module card_dsc =  
    let card_game (card:int) : string = 
            let number = card % 13
            match number with 
            | number when number = 1 || number = 14 -> "Ace"
            | number when number = 13 -> "King"
            | number when number = 12 -> "Queen"
            | number when number = 11 -> "Jack"
            | _ -> string(number)
        
    printfn "%s" (card_game 11)

// Using composition write a function composed of two functions
// The first function subtracts it by 9
// The second functions divides by 2
module composition = 
    let subtract_func x = x - 9

    let divide_by_2 x = x / 2

    let sub_and_divide = subtract_func >> divide_by_2

    printfn "%i" (sub_and_divide 12)

// Use pipeline by giving arguments to a function which sorts them, then prints each element
module pipeline =
    let custom_list = [4; 98; 12; 45; 56]
    let sort_list (list:int list) = List.sort(list)
   
    let print_elements (list: int list) = List.iter(printfn "%i") list
    
    custom_list |> sort_list |> print_elements

// Take a deck of cards, shuffle it, take the top three cards,
// and then print the results using pipelines
module pipeline_card = 
    let cards = [21; 3; 1; 7; 9; 23]
    let cardFace card = 
        let no = card % 13
        if no = 1 then "Ace"
        elif no = 0 then "King"
        elif no = 12 then "Queen"
        elif no = 11 then "Jack"
        else string no

    let suit card =
        let no = card / 13
        if no = 0 then "Hearts"
        elif no = 1 then "Spades"
        elif no = 2 then "Diamonds"
        else "Clubs"

    let shuffle list =
        let random = System.Random()
        list |> List.sortBy (fun x -> random.Next())

    let printCard card = printfn "%s of %s" (cardFace card) (suit card)

    let printAll list = List.iter(fun x -> printCard(x)) list

    let take (no:int) list = List.take no list

    cards |> shuffle |> take 3 |> printAll

// Define a list of type string with 4 random elements of your preference
module list_in_fsharp = 
    let my_list = ["This"; "is"; "for"; "Adam"]

// Create a new list by adding a new element to this list
module element_added = 
    let my_list = ["This"; "is"; "for"; "Adam"]

    let my_new_list = "Hi" :: my_list
    printf "%A" my_new_list

// use @ sign to join combine two lists
module using_at_sign = 
    let first_list = ["Hi"; "son"]
    let second_list = ["Hi"; "daughter"]
    let final_list = first_list @ second_list

// Add items to an existing list by using append function
module add_to_list = 
    let cards = ["King"; "Queen"; "Ace"]
    let final_cards = cards |> List.append["Jack"]

// Access an item in a list using item property
module access_item_in_list =
    let fruits = ["Apple"; "Banana"; "Peach"]
    
    printfn "%s" (fruits.Item(2)) // Peach

// Access the first element in a list
module head_fsharp = 
    let fruits = ["Apple"; "Banana"; "Peach"]
    
    printfn "%s" fruits.Head // Apple

// Access every element except head
module tail_fsharp = 
    let fruits = ["Apple"; "Banana"; "Peach"]
    
    printfn "%A" fruits.Tail // ["Banana"; "Peach"]

// Measure length of a list
module length_list = 
    let fruits = ["Apple"; "Banana"; "Peach"]
    
    printfn "%i" fruits.Length // 3

// Check whether list is empty or not
module empty_list = 
    let fruits = ["Apple"; "Banana"; "Peach"]

    printfn "%b" fruits.IsEmpty // false
    
// Use iter to loop over elements of a list and print each item
module iter_list_print = 
    let my_list = [1..10]
    List.iter(fun x -> printfn "%i" x) my_list

// Write a program that given a list, transforms elements by multiplying them by two
module multiply_by_two = 
    let my_list = [1..10]
    let new_list = List.map(fun x -> x * 2) my_list
    printfn "%A" new_list

// Define type person composed of first name and last name
module map_person = 
    type person = {first_name: string; last_name:string}         

    // Define list of person
    let people = [
                 { first_name = "John"; last_name = "Lennon" }
                 {first_name = "Roger"; last_name = "Waters"}
                 ]

    // Using map function, transform the list
    let result = List.map(fun p -> p.first_name + " " + p.last_name) people

    printfn "%A" result

// Use filter function to filter a list of numbers between 1 to 10 if they are divisable by 2
module divisable_by_two_filter =
    let int_list = [1..10]
    let filtered_list = List.filter(fun (x: int) -> x % 2 = 0) int_list
    // Print final result
    printfn "%A" filtered_list

// Use sort function on a list of integers
module sort_on_int_list =
    let unsorted = [34; 12; 1; 98; 6]
    let sorted_list = List.sort unsorted
    
    // Iterate over sorted list
    List.iter(fun x-> printfn "%i" x) sorted_list

// Use sortBy by using the length of string as your key on a list of strings
module sortBy_str_list =
    let pizza = ["pepperoni"; "funghi"; "quattro formaggi"]
    let sorted = List.sortBy(fun (str:string) -> str.Length) pizza
    
    List.iter(fun (i:string) -> printfn "%s" i) sorted

// Use searchWith
module searchWith_creature =
    type magicCreature = {name:string; level: int; damage: int}
    let creatures = [
        {name = "Huma"; level = 12; damage = 24}
        {name = "Ghoghnoos"; level = 9; damage = 18}
        ]
    
    let compare_Creatures creature1 creature2 =
        match (creature1, creature2) with
        | creature1, creature2 when creature1.level < creature2.level -> -1
        | creature1, creature2 when creature1.level > creature2.level -> 1
        | creature1, creature2 when creature1.damage < creature2.damage -> -1
        | creature1, creature2 when creature1.damage > creature2.damage -> 1
        | _ -> 0
    let sorted = List.sortWith compare_Creatures creatures
    printfn "%A" sorted

// Use find() function on a list
module find_int_list =
    let int_list = [1..20]
    let result = List.find(fun (i:int) -> i % 2 =0) int_list
    printfn "First item found is: %i" result

// Use tryFind()

module tryFind_list =
    let tryfind custom_value c_list =
        let found = c_list |> List.tryFind(fun (item:int) -> item = custom_value)
        match found with
            | Some value -> printfn "%i" value
            | _ -> printfn "Not found"
    
    tryfind 1 [1..100]

// Sum all elements within a list
module sum_list =
    let int_list = [1..33]
    let sum_result = List.sum int_list
    printfn "%i" sum_result

// Use sumBy on a custom type defined by yourself
module sumBy_exercise =
    
    type order_details = {product : string; price: int}
    
    let order_details = [
        {product = "Bamboo flute"; price = 24}
        {product = "Milk"; price = 4}
        {product = "Tartufi Bianchi"; price = 100}
    ]
    
    let final_summation = List.sumBy(fun item -> item.price) order_details
    printfn $"Total cost: {final_summation} dollars"

// Use average function on a list of numbers
module avg_NumberList =
    
    let n_list = [1.4; 94.3; 0.4; 12.4]
    let avg_list = List.average n_list
    printfn $"Average of list: {avg_list}"

// Use averageBy function
module avgBy_customType =
    type zone = {city: string; temp: float}
    
    let zones = [
        {city = "Paris"; temp = 10.2}
        {city = "New York"; temp = 18.9}
        {city = "London"; temp = 12.4}
    ]
    
    let avgBy_temp = List.averageBy(fun item -> item.temp) zones
    printfn $"Average of temps: {avgBy_temp}"
