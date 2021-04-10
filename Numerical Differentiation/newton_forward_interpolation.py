#Numerical Differentiation using Newton's Forward Interpolation

import math

#mul will give p*(p-1) for n times
def mul(p,n):
    temp=p
    for i in range(1,n):
        p=(p*(temp-1))
        temp-=1
    return p

#x[] is input points list and pt is point for which output is to be found
def forward_interpolation(x,y,pt):

    #calculating forward difference table
    diff=[]
    
    n=len(y)
    for temp in range(0,n):
        diff.append([])         #creating empty list to store forward differences

    cnt=1
    diff[0]=y
    n_diff=len(y)

    while cnt<=n-1:
        #print('cnt:',cnt)
        for i in range(0,n_diff-1):
            #print('i:',i)
            diff[cnt].append(diff[cnt-1][i+1]-diff[cnt-1][i])
        n_diff=len(diff[cnt])
        cnt+=1


    #printing forward difference table
    print('--------------------Forward Difference Table--------------------')
    for i in range(1,n):
        print('Del^',i,'.y0',' :', diff[i])
    print('----------------------------------------------------------------')

    
    #to find P
    h=x[1]-x[0]         #h=step size
    '''
    for i in range(0,n):
        if pt<=x[i]:
            x0=x[i-1]   #x0 immediate previous value of x
            break
    '''
    #p=(x-x0)/h
    x0=0
    p=(pt-x0)/h
    #print('x0: ',x0)
    #print('p: ',p)

    #finding position of x to find f(x)
    pos=0
    for i in range(0,n):
        if x0==x[i]:
            pos=i
            break
    
    fx=diff[0][pos]
    #print(fx)
    sum=0
    for i in range(1,n):
        sum+=((mul(p,i)*diff[i][0])/math.factorial(i))

    #print('fx: ',fx)
    answer=fx+sum

    print('Value at point',pt,'is =',answer)
    

#TEST CASE 1
x=[0,5,10,15,20]
y=[1.0,1.6,3.8,8.2,15.4]
n=3
#TEST CASE 2
#x=[45,50,55,60]
#y=[0.7071,0.7660,0.8192,0.8660]
#n=52
forward_interpolation(x,y,n)    
#print('mul: ',mul(0.6,3))

'''
OUTPUT:
--------------------Forward Difference Table--------------------
Del^ 1 .y0  : [0.6000000000000001, 2.1999999999999997, 4.3999999999999995, 7.200000000000001]
Del^ 2 .y0  : [1.5999999999999996, 2.1999999999999997, 2.8000000000000016]
Del^ 3 .y0  : [0.6000000000000001, 0.6000000000000019]
Del^ 4 .y0  : [1.7763568394002505e-15]
----------------------------------------------------------------

Value at point 3 is = 1.2016
'''
