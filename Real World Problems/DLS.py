#Program to implement DLS Method 


def get_resources_used(resources,innings, overs,r):
    interruptions=int(input('Enter the number of interruptions in the '+str(innings)+' innings: '))

    cnt=0
    prev_resources=r
    total_overs=overs
    
    while cnt<interruptions:
        print('\n---- INTERRUPTION',cnt+1,'----')
        run=int(input('Runs: '))
        wickets=int(input('Wickets: '))
        overs=int(input('Overs Bowled: '))          #here we are accepting overs bowled not remaining
        #overs remaining=50 - overs bowled
        r=resources[50-(total_overs-overs)][wickets]             #resources lost

        reduced=int(input('Overs reduced to:'))

        #update new total overs to reduced overs
        total_overs=reduced

        
        #print('r:',r)

        #update remaining resources
        prev_resources-=r
        remaining_overs=reduced-overs
        new_r=resources[50-remaining_overs][wickets]
        #print('new_r:',new_r)
        prev_resources+=new_r
        print('\nResources used:',prev_resources)
        
        cnt+=1
    return (prev_resources,total_overs)


#function to get target for Team 2 based on resources used
def get_target(r1,r2,team1_total):
    G50=260
    if r2<r1:
        target=team1_total*(r2/r1)
    elif r2==r1:
        target=team1_total+1
    else:
        target=team1_total+(G50*(r2-r1)/100)
    return round(target)



#function to implement DLS
def DLS(resources):

    #for Team1
    print('----------------FIRST INNINGS----------------\n')

    team1_total=int(input('Enter Team1\'s Total Score: '))
    team1_wickets=int(input('Enter Team1\'s Total Wickets: '))

    r1,total_overs=get_resources_used(resources,1,50,100)       #get resources used by Team1 and overs played
    

    r2=resources[50-total_overs][0]                             #calculate total resources available for Team 2 at start of their inning
    print('Resources available for Team 2:',r2)


    target=get_target(r1,r2,team1_total)
        
    print('Target for Team 2: ',target)


    #for Team2
    print('\n----------------SECOND INNINGS----------------\n')

    res,overs=get_resources_used(resources,2,total_overs,r2)

    target=get_target(r1,res,team1_total)
    print('Revised target for Team 2:',target) 


    


resources = [
                #    0        1    2     3   4    5    6    7     8    8    9
                    [100.0, 93.4, 85.1, 74.9, 62.7, 49.0, 34.9, 22.0, 11.9, 4.7 ],      #50
                    [99.1,  92.6, 84.5, 74.4, 62.5, 48.9, 34.9, 22.0, 11.9, 4.7],       #49
                    [98.1,  91.7, 83.8, 74.0, 62.2, 48.8, 34.9, 22.0, 11.9, 4.7],       #48
                    [97.1,90.9,83.2,73.5,61.9,48.6,34.9,22.0,11.9,4.7],                 #47
                    [96.1,90.0,82.5,73.0,61.6,48.5,34.8,22.0,11.9,4.7],                 #46
                    [95.0,89.1,81.8,72.5,61.3,48.4,34.8,22.0,11.9,4.7],                 #45
                    [93.9,88.2,81.0,72.0,61.0,48.3,34.8,22.0,11.9,4.7],                 #44
                    [92.8,87.3,80.3,71.4,60.7,48.1,34.7,22.0,11.9,4.7],                 #43
                    [91.7,86.3,79.5,70.9,60.3,47.9,34.7,22.0,11.9,4.7],                 #42
                    [90.5,85.3,78.7,70.3,59.9,47.8,34.6,22.0,11.9,4.7],                 #41
                    [89.3,84.2,77.8,69.6,59.5,47.6,34.6,22.0,11.9,4.7],                 #40
                    [88.0,83.1,76.9,69.0,59.1,47.4,34.5,22.0,11.9,4.7],                 #39
                    [86.7,82.0,76.0,68.3,58.7,47.1,34.5,21.9,11.9,4.7],                 #38
                    [85.4,80.9,75.0,67.6,58.2,46.9,34.4,21.9,11.9,4.7],                 #37
                    [84.1,79.7,74.1,66.8,57.7,46.6,34.3,21.9,11.9,4.7],                 #36
                    [82.7,78.5,73.0,66.0,57.2,46.4,34.2,21.9,11.9,4.7],                 #35
                    [81.3,77.2,72.0,65.2,56.6,46.1,34.1,21.9,11.9,4.7],                 #34
                    [79.8,75.9,70.9,64.4,56.0,45.8,34.0,21.9,11.9,4.7],                 #33
                    [78.3,74.6,69.7,63.5,55.4,45.4,33.9,21.9,11.9,4.7],                 #32
                    [76.7,73.2,68.6,62.5,54.8,45.1,33.7,21.9,11.9,4.7],                 #31
                    [75.1,71.8,67.3,61.6,54.1,44.7,33.6,21.8,11.9,4.7],                 #30
                    [73.5,70.3,66.1,60.5,53.4,44.2,33.4,21.8,11.9,4.7],                 #29
                    [71.8,68.8,64.8,59.5,52.6,43.8,33.2,21.8,11.9,4.7],                 #28
                    [70.1,67.2,63.4,58.4,51.8,43.3,33.0,21.7,11.9,4.7],                 #27
                    [68.3,65.6,62.0,57.2,50.9,42.8,32.8,21.7,11.9,4.7],                 #26
                    [66.5,63.9,60.5,56.0,50.0,42.2,32.6,21.6,11.9,4.7],                 #25
                    [64.6,62.2,59.0,54.7,49.0,41.6,32.3,21.6,11.9,4.7],                 #24
                    [62.7,60.4,57.4,53.4,48.0,40.9,32.0,21.5,11.9,4.7],                 #23
                    [60.7,58.6,55.8,52.0,47.0,40.2,31.6,21.4,11.9,4.7],                 #22
                    [58.7,56.7,54.1,50.6,45.8,39.4,31.2,21.3,11.9,4.7],                 #21
                    [56.6,54.8,52.4,49.1,44.6,38.6,30.8,21.2,11.9,4.7],                 #20
                    [54.4,52.8,50.5,47.5,43.4,37.7,30.3,21.1,11.9,4.7],                 #19
                    [52.2,50.7,48.6,45.9,42.0,36.8,29.8,20.9,11.9,4.7],                 #18
                    [49.9,48.5,46.7,44.1,40.6,35.8,29.2,20.7,11.9,4.7],                 #17
                    [47.6,46.3,44.7,42.3,39.1,34.7,28.5,20.5,11.8,4.7],                 #16
                    [45.2,44.1,42.6,40.5,37.6,33.5,27.8,20.2,11.8,4.7],                 #15
                    [42.7,41.7,40.4,38.5,35.9,32.2,27.0,19.9,11.8,4.7],                 #14
                    [40.2,39.3,38.1,36.5,34.2,30.8,26.1,19.5,11.7,4.7],                 #13
                    [37.6,36.8,35.8,34.3,32.3,29.4,25.1,19.0,11.6,4.7],                 #12
                    [34.9,34.2,33.4,32.1,30.4,27.8,24.0,18.5,11.5,4.7],                 #11
                    [32.1,31.6,30.8,29.8,28.3,26.1,22.8,17.9,11.4,4.7],                 #10
                    [29.3,28.9,28.2,27.4,26.1,24.2,21.4,17.1,11.2,4.7],                 #9
                    [26.4,26.0,25.5,24.8,23.8,22.3,19.9,16.2,10.9,4.7],                 #8  
                    [23.4,23.1,22.7,22.2,21.4,20.1,18.2,15.2,10.5,4.7],                 #7
                    [20.3,20.1,19.8,19.4,18.8,17.8,16.4,13.9,10.1,4.6],                 #6
                    [17.2,17.0,16.8,16.5,16.1,15.4,14.3,12.5,9.4,4.6],                  #5
                    [13.9,13.8,13.7,13.5,13.2,12.7,12.0,10.7,8.4,4.5],                  #4
                    [10.6,10.5,10.4,10.3,10.2,9.9,9.5,8.7,7.2,4.2],                     #3
                    [7.2,7.1,7.1,7.0,7.0,6.8,6.6,6.2,5.5,3.7],                          #2
                    [3.6,3.6,3.6,3.6,3.6,3.5,3.5,3.4,3.2,2.5],                          #1
                    [0,0,0,0,0,0,0,0,0,0]                                               #0
                ]
DLS(resources)


'''
OUTPUT:


----------------FIRST INNINGS----------------

Enter Team1's Total Score: 228
Enter Team1's Total Wickets: 5
Enter the number of interruptions in the 1 innings: 2

---- INTERRUPTION 1 ----
Runs: 68
Wickets: 1
Overs Bowled: 13
Overs reduced to:47

Resources used: 96.3

---- INTERRUPTION 2 ----
Runs: 168
Wickets: 3
Overs Bowled: 28
Overs reduced to:35

Resources used: 71.0
Resources available for Team 2: 82.7
Target for Team 2:  258

----------------SECOND INNINGS----------------

Enter the number of interruptions in the 2 innings: 1

---- INTERRUPTION 1 ----
Runs: 30
Wickets: 1
Overs Bowled: 6
Overs reduced to:30

Resources used: 74.60000000000001
Revised target for Team 2: 237

'''
   
