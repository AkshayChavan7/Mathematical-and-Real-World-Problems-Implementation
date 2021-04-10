#Numerical Integration using Left-Riemann Sums
import math

def f(x):
    return (1-(x*x)) 


def riemann(a,b,n):

    del_x=(b-a)/n
    print('del_x:', del_x)

    x=[]
    t=0
    i=a
    while t<=n:
        i=f(a+(t*del_x))
        x.append(i)
        t+=1
    print('X List: ',x)
    sum=0

    #sum for Left-Riemann (x0,x1,...x7) 
    for j in range(0,n):
        #print(j," :",x[j])
        sum+=x[j]
    print('Left Riemann Sum= ',sum*del_x)


    #sum for Right-Riemann (x1,x2,...x8)
    sum=0
    for j in range(1,n+1):
        #print(j," :",x[j])
        sum+=x[j]
    print('Right Riemann Sum= ',sum*del_x)


riemann(0,1,8)




'''
OUTPUT:

del_x: 0.125
X List:  [1.0, 0.984375, 0.9375, 0.859375, 0.75, 0.609375, 0.4375, 0.234375, 0.0]
Left Riemann Sum=  0.7265625
Right Riemann Sum=  0.6015625
'''
