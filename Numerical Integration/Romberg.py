#Romberg Integration


#Importing our trapezoidal function
import Trapezoidal as tp


#input: lower limit, upper limit, number of intervals,number of levels
def romberg(a,b,n,k):

    trap_matrix=[]

    #creating first level of tree
    for i in range(1,k+1):
        trap_matrix.append([])
        trap_matrix[0].append(tp.trapezoidal(a,b,n**i))
    #print(trap_matrix)

    cnt=1
    prev_len=len(trap_matrix[0])    #prev_len will store previous list's length
    while cnt<=k-1:
        for i in range(0,prev_len-1):       #to traverse row elements
            t1=trap_matrix[cnt-1][i+1]
            t2=(t1-trap_matrix[cnt-1][i])/(4**cnt-1)
            trap_matrix[cnt].append((t1+t2))
        prev_len=len(trap_matrix[cnt])
        cnt+=1

    print('-------------Romberg Tree-------------\n\n')
    for i in range(0,k):
        print('Level ',i+1,'-',trap_matrix[i])

    print('Area calculated by Romberg Integration=',trap_matrix[k-1][0])


romberg(0,1,5,3)



'''
OUTPUT:

-------------Romberg Tree-------------


Level  1 - [1.1501517743575271, 1.1478878574860056, 1.1477973459355024]
Level  2 - [1.1471332185288319, 1.147767175418668]
Level  3 - [1.1478094392113238]
Area calculated by Romberg Integration= 1.1478094392113238

'''
